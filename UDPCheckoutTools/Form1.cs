using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPCheckoutTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtboxHistotry.Text = "";
            try
            {
                UDPModel udpparm = new UDPModel();
                udpparm.srcIp = txtboxSrcIP.Text;
                udpparm.srcPort = Convert.ToInt32(txtboxSrcPort.Text);
                udpparm.destIp = txtboxDestIP.Text;
                udpparm.destPort = Convert.ToInt32(txtboxDestPort.Text);
                udpparm.sendOrder = txtboxSend.Text;

                txtboxRec.Text = DateTime.Now.ToLongTimeString() + ": " + txtboxSend.Text + " -> " + UDPSocket.updsocket(udpparm) + "\r\n" + txtboxRec.Text;
            }
            catch (Exception ex)
            {
                txtboxHistotry.Text = ex.ToString();
            }
        }
    }
}
