using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPCheckoutTools.Model
{
    public class SendMSG
    {
        public int Head { get; set; }
        public int Addr { get; set; }
        public int CmdDataLen { get; set; }
        public int Cmd { get; set; }
        public byte[] CmdPara { get; set; }
        public int Check { get; set; }
    }
}
