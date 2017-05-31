using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using UDPMessage.Model;

namespace UDPMessage
{
    public class UDPSendto
    {
        public static bool IsGetCardData = false;
        public static Ipformat ipformat;
        public static void Start(Ipformat ipformat1,bool IsGetCardData1)
        {
            IsGetCardData = IsGetCardData1;
            ipformat = ipformat1;

            List<byte> addrlist = new List<byte>();
            addrlist.Add(0x01);
            //addrlist.Add(0x02);

            if (!IsGetCardData)
            {
                return;
            }
            
            for (int i = 0; i < addrlist.Count; i++)
            {
                byte addr = addrlist[i];
                Run(addr);
                Thread t1 = new Thread(new ParameterizedThreadStart(POLLGetCardData));
                t1.Start(addr);
                Thread t2 = new Thread(new ParameterizedThreadStart(POLLSetTime));
                t2.Start(addr);
            }
        }

        public static void Run(byte addr)
        {
            //查询读卡器是否工作
            if (AttenceMsg.CheckStatus(ipformat, addr, null)[3] == 1)
            {
                string mRecTime = BitConverter.ToString(AttenceMsg.CheckTime(ipformat, addr, null).Skip(4).Take(4).ToArray()).Replace("-", "");
                //读取读卡器时间
                if (DateTime.Now - DateTime.Parse(mRecTime) > TimeSpan.FromMilliseconds(1000))
                {
                    SetTime(addr);
                }
            }
            else
            {
                SetTime(addr);
            }
            AttenceMsg.StartCardReading(ipformat, addr, null);
            AttenceMsg.GetCardData(ipformat, addr, null);

        }

        //每10秒读卡数据
        public static void POLLGetCardData(object addr)
        {
            while (IsGetCardData)
            {
                Thread.Sleep(10000);
                AttenceMsg.GetCardData(ipformat, (byte)addr, null);
                
            }
        }

        //每5分钟同步时间
        public static void POLLSetTime(object addr)
        {
            while (IsGetCardData)
            {
                SetTime((byte)addr);
                Thread.Sleep(300000);
            }
        }

        //同步读卡器时间
        public static void SetTime(byte addr)
        {
            ulong nowTick = (ulong)DateTime.Now.Second;
            byte[] times = new byte[4];
            times[0] = 0x00;
            times[1] = (byte)((nowTick >> 16) & 0xFF);
            times[2] = (byte)((nowTick >> 8) & 0xFF);
            times[3] = (byte)((nowTick >> 0) & 0xFF);
            AttenceMsg.SetTime(ipformat, addr, times);
        }

        //发送报文
        public static byte[] updsendto(Ipformat ipformat)
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                int recv;
                byte[] data = new byte[1024];
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipformat.srcIp), ipformat.srcPort);
                newsock.Bind(ip);
                EndPoint Remote = new IPEndPoint(IPAddress.Parse(ipformat.destIp), ipformat.destPort);
                data = ipformat.sendMsg;
                newsock.SendTo(data, data.Length, SocketFlags.None, Remote);

                data = new byte[1024];
                recv = newsock.ReceiveFrom(data, ref Remote);
                return data;
                //return BitConverter.ToString(data, 0, recv);
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
