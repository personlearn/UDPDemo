using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPMessage.Model
{
    public class Ipformat
    {
        public string srcIp { get; set; }
        public int srcPort { get; set; }
        public string destIp { get; set; }
        public int destPort { get; set; }
        public byte[] sendMsg { get; set; }
    }
}
