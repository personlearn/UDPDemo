using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UDPCheckoutTools
{
    class UDPSocket
    {
        public static string updsocket(UDPModel UDPParm)
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                //UDPParm.srcIp = "192.168.2.92";
                //UDPParm.srcPort = 6000;
                //UDPParm.destIp = "192.168.2.123";
                //UDPParm.destPort = 1300;
                //UDPParm.sendOrder = "0A010222D1";
                int recv;
                byte[] data = new byte[1024];
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(UDPParm.srcIp), UDPParm.srcPort);
                //绑定网络地址
                newsock.Bind(ip);
                EndPoint Remote = new IPEndPoint(IPAddress.Parse(UDPParm.destIp), UDPParm.destPort);
                string[] Order = Regex.Split(UDPParm.sendOrder, "(\\w{2})").Where(s => !string.IsNullOrEmpty(s)).ToArray();
                char[] orderCharArr = new char[Order.Length];
                for (int i = 0; i < Order.Length; i++)
                {
                    orderCharArr[i] = Convert.ToChar(Convert.ToInt32(Order[i], 16));
                }
                //字符串与字节数组相互转换
                data = Encoding.ASCII.GetBytes(orderCharArr);
                //发送信息
                newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                data = new byte[1024];
                //发送接收信息
                recv = newsock.ReceiveFrom(data, ref Remote);
                
                return BitConverter.ToString(data, 0, recv);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                newsock.Close();
            }
        }
    }
}
