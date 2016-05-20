﻿using TaxiSystem.Common;

namespace TaxiSystem.Protocol
{
    public class Packet : ByteBuffer
    {
        public Opcode Opcode { get; private set; }

        public Packet() : base()
        {
            this.Opcode = 0;
        }

        public Packet(Opcode opcode) : base()
        {
            this.Opcode = opcode;
        }
    }
}
