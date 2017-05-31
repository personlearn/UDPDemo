using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPMessage.Model
{
    public class ProtocolCode
    {
        public const byte REQUESTHEAD = 0x0A;
        public const byte RESPONSEHEAD = 0X0B;

        public const byte RESET = 0x21;
        public const byte CHECKVERSION = 0x22;
        public const byte SETSENSIVITY = 0x23;
        public const byte CHECKSENSIVITY = 0x24;
        public const byte SETTIME = 0x29;
        public const byte CHECKTIME = 0x2A;

        public const byte STARTCARDREADING = 0x90;
        public const byte ENDCARDREADING = 0x91;
        public const byte GETCARDDATA = 0x9A;
        public const byte CHECKSTATUS = 0x9C;
    }
}
