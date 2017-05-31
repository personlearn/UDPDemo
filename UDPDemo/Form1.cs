using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDPMessage;
using UDPMessage.Model;

namespace UDPDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnClose.Enabled = false;
        }

        private void BtnStartAttence_Click(object sender, EventArgs e)
        {
            BtnStartAttence.Enabled = false;
            btnClose.Enabled = true;
            Ipformat ipformat = new Ipformat();
            //ipformat.srcIp = "192.168.2.92";
            //ipformat.srcPort = 6000;
            //ipformat.destIp= "192.168.2.123";
            //ipformat.destPort = 1300;

            ipformat.srcIp = "127.0.0.1";
            ipformat.srcPort = 6000;
            ipformat.destIp = "127.0.0.1";
            ipformat.destPort = 6000;
            UDPSendto.Start(ipformat, true);           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            BtnStartAttence.Enabled = true;
            UDPSendto.Close(false);         
        }
    }
}
