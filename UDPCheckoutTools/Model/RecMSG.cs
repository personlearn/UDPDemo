using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPCheckoutTools.Model
{
    class RecMSG
    {
        public int Head { get; set; }
        public int Addr { get; set; }
        public int Len { get; set; }
        public int Status { get; set; }
        public int[] Response1 { get; set; }
        public int Check { get; set; }
    }
}
