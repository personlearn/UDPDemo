using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UDPMessage.Model;

namespace UDPMessage
{
    public class AttenceMsg
    {
        static DeliveryMessage msg;
        //读版本号
        public static byte[] CheckVersion(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.CHECKVERSION;

            ipformat.sendMsg=Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //查询状态
        public static byte[] CheckStatus(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.CHECKSTATUS;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //查询时间
        public static byte[] CheckTime(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.CHECKTIME;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //写入时间
        public static byte[] SetTime(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.SETTIME;
            msg.CmdPara = CmdPara;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //启动读卡
        public static byte[] StartCardReading(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.STARTCARDREADING;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //读卡数据
        public static byte[] GetCardData(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.GETCARDDATA;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //读灵敏度
        public static byte[] CheckSensivity(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.CHECKSENSIVITY;
            msg.CmdPara = CmdPara;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //写灵敏度
        public static byte[] SetSensivity(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.SETSENSIVITY;
            msg.CmdPara = CmdPara;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //结束读卡
        public static byte[] EndCardReading(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.ENDCARDREADING;
            msg.CmdPara = CmdPara;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //复位读头
        public static byte[] Reset(Ipformat ipformat, byte addr, byte[] CmdPara)
        {
            msg = new DeliveryMessage();
            msg.Addr = addr;
            msg.Cmd = ProtocolCode.RESET;

            ipformat.sendMsg = Ordermsg(msg);
            return UDPSendto.updsendto(ipformat);
        }
        //生成报文
        public static byte[] Ordermsg(DeliveryMessage msg)
        {
            byte[] dataBuffer = new byte[1024];
            int i = 0;
            dataBuffer[i++] = ProtocolCode.REQUESTHEAD;
            dataBuffer[i++] = (byte)msg.Addr;
            dataBuffer[i++] = (byte)(msg.CmdPara.Length + 2);
            dataBuffer[i++] = (byte)msg.Cmd;
            for (int j = 0; j < msg.CmdPara.Length; j++)
            {
                dataBuffer[i++] = msg.CmdPara[j];
            }
            byte checkByte = 0;
            for (int k = 0; k < i; k++)
            {
                checkByte += dataBuffer[k];
            }
            dataBuffer[i++] = (byte)(-checkByte);
            return dataBuffer;
        }
    }
}
