using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPMessage.Model
{
    public class DeliveryMessage
    {
        public byte Head { get; set; }
        public byte Addr { get; set; }
        public byte CmdDataLen { get; set; }
        public byte Cmd { get; set; }
        public byte[] CmdPara { get; set; }
        public byte Check { get; set; }
    }
}
