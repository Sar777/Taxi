﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using TaxiSystem.Common;
using TaxiSystem.Parser;
using TaxiSystem.Protocol;

namespace TaxiSystem.Networking
{
    public class TCPSocket
    {
        // ManualResetEvent instances signal completion.
        private readonly ManualResetEvent connectDone = new ManualResetEvent(false);
        private readonly ManualResetEvent sendPacketDone = new ManualResetEvent(false);
        private readonly ManualResetEvent receivePacketDone = new ManualResetEvent(false);

        private byte[] ReadBuffer;

        private Socket Socket { get; set; }

        private string IP { get; set; }
        private int Port { get; set; }

        private static TCPSocket _instance;

        private readonly System.Timers.Timer PacketTimer;
        private readonly Queue<Packet> SendPacketQueue;

        private TCPSocket()
        {
            ReadBuffer = new byte[Constants.BUFFER_SIZE];

            PacketTimer = new System.Timers.Timer(50);
            PacketTimer.Elapsed += UpdateSendQueue;
            PacketTimer.Start();

            SendPacketQueue = new Queue<Packet>();
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public static TCPSocket Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TCPSocket();
                return _instance;
            }
        }

        public bool IsOpen()
        {
            return Socket.Connected;
        }

        public void Close()
        {
            Socket.Close();
        }

        public void Connect(string ip = "", int port = 0)
        {
            if (ip != "" && port != 0)
            {
                IP = ip;
                Port = port;
            }

            // Connect to a remote device.
            try
            {
                var remoteEp = new IPEndPoint(IPAddress.Parse(IP), port);
                // Connect to the remote endpoint.
                Socket.BeginConnect(remoteEp, ConnectCallback, null);
                connectDone.WaitOne();

                // Receive the response from the remote device.
                ReceivePacket();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Complete the connection.
                Socket.EndConnect(ar);
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void SendPacketCallback(IAsyncResult ar)
        {
            try
            {
                // Signal that all bytes have been sent.
                sendPacketDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ReceivePacket()
        {
            try
            {
                // Begin receiving the data from the remote device.
                Socket.BeginReceive(ReadBuffer, 0, ReadBuffer.Length, 0, ReceiveCallback, null);
                receivePacketDone.WaitOne();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                int bytes = Socket.EndReceive(ar);
                byte[] temp = ReadBuffer;
                Array.Resize(ref temp, bytes);
                byte[] decryptBytes = Cryptography.Decrypt(temp);

                var packet = ParsePacket(decryptBytes);
                Handler.SelectHandler(packet);

                Array.Clear(ReadBuffer, 0, ReadBuffer.Length);

                try
                {
                    Socket.BeginReceive(ReadBuffer, 0, ReadBuffer.Length, 0, ReceiveCallback, null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ой, что-то пошло не так и вы были отключены от сервера...", "Соединение с сервером");
                    Application.Exit();
                }
                receivePacketDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private Packet ParsePacket(byte[] bytes)
        {
            var buffer = new ByteBuffer(bytes);
            Opcode opcode = (Opcode) buffer.ReadUInt16();
            UInt16 size = buffer.ReadUInt16();

            if (opcode >= Opcode.MAX_OPCODE)
                return null;

            if (size > 1000)
                return null;

            var packet = new Packet(opcode);
            packet.WriteBytes(buffer.GetBytes(size));
            packet.ResetPos();
            return packet;
        }

        private void WriteHeader(Packet packet)
        {
            byte[] bytes = packet.ToArray();

            packet.Clear();
            packet.WriteUInt16((ushort) packet.Opcode);
            packet.WriteUInt16((ushort) bytes.Length);
            packet.WriteBytes(bytes);
        }

        public void SendPacket(Packet packet, bool now = false)
        {
            if (!now)
                SendPacketQueue.Enqueue(packet);
            else
            {
                try
                {
                    WriteHeader(packet);
                    byte[] cryptBytes = Cryptography.Encrypt(packet.ToArray());
                    Socket.BeginSend(cryptBytes, 0, cryptBytes.Length, 0, SendPacketCallback, null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ой, что-то пошло не так и вы были отключены от сервера...", "Соединение с сервером");
                    Application.Exit();
                }
            }
        }

        private void UpdateSendQueue(object sender, ElapsedEventArgs e)
        {
            while (SendPacketQueue.Count != 0)
            {
                var packet = SendPacketQueue.Dequeue();
                WriteHeader(packet);
                byte[] cryptBytes = Cryptography.Encrypt(packet.ToArray());
                try
                {
                    Socket.BeginSend(cryptBytes, 0, cryptBytes.Length, 0, SendPacketCallback, null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ой, что-то пошло не так и вы были отключены от сервера...", "Соединение с сервером");
                    Application.Exit();
                }
            }

            sendPacketDone.WaitOne();
        }
    }
}
