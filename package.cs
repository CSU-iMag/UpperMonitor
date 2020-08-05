using System;
using System.Collections;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace UperMonitor
{
    public class PackageManager
    {
        public const byte ESC = 0x5c, SOH = 0x01, EOT = 0x04;
        public int rxCount = 0, txCount = 0;
        public ArrayList SpeedBuf = new ArrayList(),
            SteerBuf = new ArrayList(), MagBuf = new ArrayList();
        private byte lastByte = EOT, bufTop = 0;
        private byte[] rxBuffer = new byte[39];

        public void PackAndPush(SerialPort port, byte id, byte[] payload)
        {
            byte[] package = new byte[payload.Length + 4];
            payload.CopyTo(package, 2);
            package[0] = SOH;
            package[1] = id;
            package[package.Length - 1] = EOT;
            package[package.Length - 2] = ParitySum(payload);

            try
            {
                port.Write(package, 0, package.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法写入串口：" + ex.Message);
            }
            txCount += package.Length;
        }

        private bool PushToBuffer(byte b)
        {
            if (rxBuffer.Length > bufTop + 1)
                rxBuffer[bufTop++] = b;
            else
                return false;
            return true;
        }

        public bool VerifySOH(byte newByte)
        { // 找到帧头
            ++rxCount;
            bool ret = (lastByte != ESC && newByte == SOH);
            lastByte = newByte;
            return ret;
        }

        private bool esc = false; // 是否转义
        public bool VerifyEOT(byte newByte, MainForm owner)
        { // 找到帧尾
            ++rxCount;
            if (!esc && newByte == EOT && CheckParity())
            { // 检测到帧尾
                AnalysePackages(owner);
            }
            else if (!esc && newByte == ESC)
            {
                esc = true; // 转义下一个字节
                return false;
            }
            else
            {
                esc = false;
                if (PushToBuffer(newByte))
                    return false; // 继续读当前帧
            }

            bufTop = 0;
            return true; // 超出缓冲区，寻找下一个包
        }

        private void AnalysePackages(MainForm owner)
        { // 解析当前帧，判定是那个数据包
            SpeedPackage speed = new SpeedPackage();
            SteerPackage steering = new SteerPackage();
            DeepPackage deep = new DeepPackage();

            switch (rxBuffer[0])
            {
                case 0x8a: // 方向
                    steering.DecodePayload(rxBuffer);
                    SteerBuf.Add(steering);
                    break;

                case 0x8b: // 速度
                    speed.DecodePayload(rxBuffer);
                    if (SpeedBuf.Count > 999)
                        SpeedBuf.RemoveAt(0);
                    SpeedBuf.Add(speed);
                    owner.BeginInvoke(new MethodInvoker(() =>
                    {
                        owner.lblSpeedL.Text = "左轮速度：" + speed.SpeedL.ToString() + " cm/s";
                        owner.lblSpeedR.Text = "右轮速度：" + speed.SpeedR.ToString() + " cm/s";
                    }));
                    break;

                case 0x8c: // AI 
                    deep.DecodePayload(rxBuffer);
                    MagBuf.Add(deep);
                    break;

                case 0x8d: // 开关
                    owner.BeginInvoke(new MethodInvoker(() =>
                    {
                        for (int i = 0; i < 8; ++i)
                            owner.checkedListBox.SetItemChecked(i, (rxBuffer[1] & (1 << i)) > 0);
                    }));
                    break;

                case 0x8e: // 电磁
                    break;

                case 0x8f: // 日志
                    string str = Encoding.UTF8.GetString(rxBuffer, 2, bufTop - 3);
                    Color color = Color.Black;
                    switch (rxBuffer[1])
                    {
                        case 1: color = Color.Red; break;
                        case 2: color = Color.Green; break;
                        case 3: color = Color.Blue; break;
                    }
                    owner.BeginInvoke(new MethodInvoker(() =>
                    {
                        owner.richLogBox.SelectionColor = color;
                        owner.richLogBox.AppendText(str);
                    }));
                    break;
                default: break;
            }
        }

        public byte ParitySum(byte[] arr)
        {
            byte sum = 0;
            foreach (byte i in arr)
                sum += i;
            return sum;
        }

        private bool CheckParity()
        {
            if (bufTop < 3)
                return false;
            byte[] p = new byte[bufTop - 2];
            Array.Copy(rxBuffer, 1, p, 0, bufTop - 2);
            return ParitySum(p) == rxBuffer[bufTop - 1];
        }
    }


    public class PIDPackage
    {
        public float Kp, Ki, Kd;
        public byte[] Payload = new byte[12];

        public void EncodePayload()
        {
            Array.Copy(BitConverter.GetBytes(Kp), 0, Payload, 0, 4);
            Array.Copy(BitConverter.GetBytes(Ki), 0, Payload, 4, 4);
            Array.Copy(BitConverter.GetBytes(Kd), 0, Payload, 8, 4);
        }
    }

    class DeepPackage
    {
        public byte steering;
        public byte[] sensor;

        public void DecodePayload(byte[] payload)
        {
            steering = payload[1];
            sensor = new byte[7];
            for (int i = 0; i < 7; ++i)
                sensor[i] = payload[i + 2];
        }
    }

    class SpeedPackage
    {
        public int SpeedL, SpeedR, DutyL, DutyR;

        public void DecodePayload(byte[] payload)
        {
            SpeedL = (Int16)(payload[1] << 8) | payload[2];
            SpeedR = (Int16)(payload[3] << 8) | payload[4];
            DutyL = payload[5];
            DutyR = payload[6];
        }
    }

    class SteerPackage
    {
        public int Width, Error, Left, Middle, Right;

        public void DecodePayload(byte[] payload)
        {
            Width = payload[1];
            Error = payload[2];
        }
    }

}
