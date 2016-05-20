using System;
using TaxiSystem.AuthForms;
using TaxiSystem.Common.Enums;
using TaxiSystem.Parser;
using TaxiSystem.Protocol.Enums;
using TaxiSystem.UserForms;
using TaxiSystem.UserForms.Client;

namespace TaxiSystem.Protocol
{
    public class Handlers
    {
        [Parser(Opcode.SMSG_AUTH_RESPONSE)]
        public static void HandleAuthResponse(Packet packet)
        {
            var response = (AuthResponse)packet.ReadUInt8();
            var userId = packet.ReadInt32();
            var username = packet.ReadUTF8String();
            var userType = (UserType) packet.ReadUInt8();
            AuthForm.Form.Invoke(new Action(() =>
            {
                AuthForm.Form.Auth(userId, username, userType, response);
            }));
        }

        [Parser(Opcode.SMSG_REGISTRATION_RESPONSE)]
        public static void HandleRegistrationResponse(Packet packet)
        {
            var response = (RegistrationResponse)packet.ReadUInt8();
            var userId = packet.ReadInt32();
            var username = packet.ReadUTF8String();
            var userType = (UserType)packet.ReadUInt8();
            RegForm.Form.Invoke(new Action(() =>
            {
                RegForm.Form.Registration(userId, username, userType, response);
            }));
        }

        [Parser(Opcode.SMSG_GET_TAXI_INFO_RESPONSE)]
        public static void HandleGetTaxiInfoResponse(Packet packet)
        {
            AuthForm.Form.Invoke(new Action(() =>
            {
                ClientForm.Form.LoadTaxiInfo(packet);
            }));
        }

        [Parser(Opcode.SMSG_GET_ORDER_RESPONSE)]
        public static void HandleGetOrderResponse(Packet packet)
        {
            OrderInformationForm.Form.Invoke(new Action(() =>
            {
                OrderInformationForm.Form.ParseInfo(packet);
            }));
        }
    }
}
