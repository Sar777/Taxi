using System;
using TaxiSystem.Protocol;

namespace TaxiSystem.Parser
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class ParserAttribute : System.Attribute
    {
        public ParserAttribute(Opcode opcode)
        {
            Opcode = opcode;
        }

        public Opcode Opcode { get; private set; }
    }
}
