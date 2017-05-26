using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPCheckoutTools
{
    class UDPModel
    {
        public string srcIp { get; set; }
        public int srcPort { get; set; }
        public string destIp { get; set; }
        public int destPort { get; set; }
        public string sendOrder { get; set; }
    }
}
