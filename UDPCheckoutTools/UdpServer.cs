using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPCheckoutTools
{
    class UdpServer
    {
        public Socket serverSocket;
        public byte[] dataStream;
        public byte[] receivedBytes;
        public EndPoint epSender;

        // 关闭前一个窗口的回调函数
        public delegate void OnDataReceived();
        public event OnDataReceived onDataReceive;

        public UdpServer()
        {
            this.dataStream = new byte[10240];
        }

        public void Open(int port)
        {
            this.serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint serverPoint = new IPEndPoint(IPAddress.Any, port);
            this.serverSocket.Bind(serverPoint);
        }

        public void Close()
        {
            this.serverSocket.Shutdown(SocketShutdown.Both);
            this.serverSocket.Close();

            this.serverSocket.Shutdown(SocketShutdown.Both);
            this.serverSocket.Close();
        }

        public void Listen()
        {
            try
            {
                IPEndPoint clientPoint = new IPEndPoint(IPAddress.Any, 0);
                this.epSender = (EndPoint)clientPoint;
                this.serverSocket.BeginReceiveFrom(this.dataStream, 0,
                                        this.dataStream.Length,
                                        SocketFlags.None,
                                        ref epSender,
                                        new AsyncCallback(ReceiveData),
                                        epSender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UDP连接创建失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveData(IAsyncResult asyncResult)
        {
            try
            {
                int recv_len = serverSocket.EndReceiveFrom(asyncResult, ref epSender);
                this.serverSocket.BeginReceiveFrom(this.dataStream, 0,
                                        this.dataStream.Length,
                                        SocketFlags.None,
                                        ref epSender,
                                        new AsyncCallback(ReceiveData),
                                        epSender);

                receivedBytes = new byte[recv_len];
                Array.Copy(dataStream, 0, receivedBytes, 0, recv_len);

                Console.WriteLine("got " + recv_len.ToString() + " Bytes");
                Console.WriteLine("str is: " + Encoding.ASCII.GetString(dataStream, 0, recv_len));

                onDataReceive();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UDP接收异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
        public void SendTo(IPEndPoint dstEndPoint, byte[] byteData,int length) {
            EndPoint dstHost = (EndPoint)dstEndPoint;
            // Begin sending the data to the remote device.
            this.serverSocket.BeginSendTo(byteData, 0, length, 
                    SocketFlags.None, dstHost,
            new AsyncCallback(SendCallback), this.serverSocket);
        }*/


        private void SendTo(IPEndPoint dstEndPoint, string text)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(text);
            EndPoint dstHost = (EndPoint)dstEndPoint;
            // Begin sending the data to the remote device.
            this.serverSocket.BeginSendTo(byteData, 0, byteData.Length,
                    SocketFlags.None, dstHost,
            new AsyncCallback(SendCallback), this.serverSocket);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                //handler.Shutdown(SocketShutdown.Both);
                //handler.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UDP发送异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //public static void Main()
        //{
        //    IPEndPoint dstPoint = new IPEndPoint(IPAddress.Parse("192.168.65.230"), 7000);//发送到本地7000端口
        //    UdpServer udpServer = new UdpServer();
        //    udpServer.Open(6000);    //本地侦听6000端口
        //    udpServer.Listen();
        //    udpServer.SendTo(dstPoint, "Hello World!!!");

        //    while (true)
        //    {

        //    }
        //}
    }
}
