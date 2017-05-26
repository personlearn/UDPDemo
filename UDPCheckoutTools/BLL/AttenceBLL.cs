using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDPCheckoutTools.Model;

namespace UDPCheckoutTools.BLL
{
    class AttenceBLL
    {
        SendMSG msg;
        //读版本号
        public void CheckVersion(int addr)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.CheckVersion;

            Ordermsg(msg);
        }
        //查询状态
        public void CheckStatus(int addr)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.CheckStatus;

            Ordermsg(msg);
        }
        //查询时间
        public void CheckTime(int addr)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.CheckTime;

            Ordermsg(msg);
        }
        //写入时间
        public void SetTime(int addr,byte[] CmdPara)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.CheckTime;
            msg.CmdPara = CmdPara;

            Ordermsg(msg);
        }
        //启动读卡
        public void StartCardReading(int addr)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.CheckTime;

            Ordermsg(msg);
        }
        //读卡数据
        public void GetCardData(int addr)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.GetCardData;

            Ordermsg(msg);
        }
        //读灵敏度
        public void CheckSensivity(int addr, byte[] CmdPara)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.GetCardData;
            msg.CmdPara = CmdPara;

            Ordermsg(msg);
        }
        //写灵敏度
        public void SetSensivity(int addr, byte[] CmdPara)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.GetCardData;
            msg.CmdPara = CmdPara;

            Ordermsg(msg);
        }
        //结束读卡
        public void EndCardReading(int addr, byte[] CmdPara)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.GetCardData;
            msg.CmdPara = CmdPara;

            Ordermsg(msg);
        }
        //复位读头
        public void Reset(int addr)
        {
            msg = new SendMSG();
            msg.Addr = addr;
            msg.Cmd = CmdCode.GetCardData;

            Ordermsg(msg);
        }
        //生成报文
        public byte[] Ordermsg(SendMSG msg)
        {
            byte[] dataBuffer = new byte[1024];
            int i = 0;
            dataBuffer[i++] = CmdCode.Head;
            dataBuffer[i++] = (byte)msg.Addr;
            dataBuffer[i++] = (byte)(msg.CmdPara.Length + 2);
            dataBuffer[i++] = (byte)msg.Cmd;
            for(int j = 0; j < msg.CmdPara.Length; j++)
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
