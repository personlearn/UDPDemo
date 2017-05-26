using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPCheckoutTools.Model
{
    public class CmdCode
    {
        public const int Head = 0x0A;

        public const int Reset = 0x21;
        public const int CheckVersion = 0x22;
        public const int SetSensivity = 0x23;
        public const int CheckSensivity = 0x24;
        public const int SetTime = 0x29;
        public const int CheckTime = 0x2A;

        public const int StartCardReading = 0x90;
        public const int EndCardReading = 0x91;
        public const int GetCardData = 0x9A;
        public const int CheckStatus = 0x9C;

    }
}
