using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.Threading;
using System.IO;

namespace UperMonitor
{
    public partial class MainForm : Form
    {
        PackageManager packMgr = new PackageManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshPortNameBox()
        { // 刷新串口列表
            portComboBox.Items.Clear();
            portComboBox.Items.AddRange(SerialPort.GetPortNames());
            portComboBox.SelectedIndex = 0;
        }

        private void TryToOpenPort()
        {  // 开启串口
            port.BaudRate = Convert.ToInt32(baudComboBox.Text);
            port.PortName = portComboBox.Text;
            try
            {
                port.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法打开串口：" + ex.Message);
            }
        }

        public void PlotMagnetic()
        {
            foreach (var it in magChart.Series)
                it.Points.Clear();

            DeepPackage[] buf;
            Thread.BeginCriticalRegion();
            buf = new DeepPackage[packMgr.MagBuf.Count];
            packMgr.MagBuf.CopyTo(buf);
            Thread.EndCriticalRegion();

            int cnt = 0;
            foreach (var it in buf)
            {
                ++cnt;
                for (int i = 0; i < 7; ++i)
                    magChart.Series[i].Points.AddXY(cnt, it.sensor[i]);
            }
        }

        public void PlotSpeed()
        {
            int cnt = 0;
            foreach (var it in speedChart.Series)
                it.Points.Clear();
            SpeedPackage[] buf;

            Thread.BeginCriticalRegion();
            buf = new SpeedPackage[packMgr.SpeedBuf.Count];
            packMgr.SpeedBuf.CopyTo(buf);
            Thread.EndCriticalRegion();

            foreach (SpeedPackage it in buf)
            {
                if (it.SpeedL > -128 && it.SpeedL < 128)
                    speedChart.Series[0].Points.AddXY(cnt, it.SpeedL);
                if (it.SpeedR > -128 && it.SpeedR < 128)
                    speedChart.Series[1].Points.AddXY(cnt, it.SpeedR);
                speedChart.Series[2].Points.AddXY(cnt, it.DutyL);
                speedChart.Series[3].Points.AddXY(cnt, it.DutyR);
                ++cnt;
            }
        }

        public void PlotSteering()
        {
            int cnt = 0;
            foreach (var it in steerChart.Series)
                it.Points.Clear();
            foreach (SteerPackage it in packMgr.SteerBuf)
            {
                steerChart.Series[0].Points.AddXY(cnt, it.Error);
                steerChart.Series[1].Points.AddXY(cnt, it.Width);
                ++cnt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { // 初始化默认值
            baudComboBox.SelectedIndex = 3;
            port.NewLine = "\x4"; // EOT
            RefreshPortNameBox();
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        { // 串口接收回调函数
            try
            {
                while (port.BytesToRead > 0)
                {
                    while (!packMgr.VerifySOH((byte)port.ReadByte())) { }
                    while (!packMgr.VerifyEOT((byte)port.ReadByte(), this)) { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            RefreshPortNameBox();
        }

        private void enPortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            portComboBox.Enabled = baudComboBox.Enabled = !(btnSendSpeed.Enabled =
               checkedListBox.Enabled = btnSendSteer.Enabled = enPortCheckBox.Checked);
            port.Close();
            if (enPortCheckBox.Checked)
                TryToOpenPort();
        }

        private void btnSendSteer_Click(object sender, EventArgs e)
        {
            PIDPackage sp = new PIDPackage();
            sp.Kp = Convert.ToSingle(numSteerKp.Value);
            sp.Ki = Convert.ToSingle(numSteerKi.Value);
            sp.Kd = Convert.ToSingle(numSteerKd.Value);
            sp.EncodePayload();
            packMgr.PackAndPush(port, 0x2b, sp.Payload);
        }

        private void btnSendSpeed_Click(object sender, EventArgs e)
        {
            PIDPackage sp = new PIDPackage();
            sp.Kp = Convert.ToSingle(numSpeedKp.Value);
            sp.Ki = Convert.ToSingle(numSpeedKi.Value);
            sp.Kd = Convert.ToSingle(numSpeedKd.Value);
            sp.EncodePayload();
            packMgr.PackAndPush(port, 0x2a, sp.Payload);
        }

        private void timerPlot_Tick(object sender, EventArgs e)
        {
            PlotSteering();
            PlotSpeed();
            PlotMagnetic();
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            byte[] enabled = new byte[1];
            for (int i = 0; i < 8; ++i)
                if (checkedListBox.GetItemChecked(i))
                    enabled[0] |= (byte)(1 << i);
            if (e.NewValue != 0)
                enabled[0] |= (byte)(1 << e.Index);
            else
                enabled[0] &= (byte)~(byte)(1 << e.Index);
            packMgr.PackAndPush(port, 0x2c, enabled);
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            packMgr.SpeedBuf.Clear();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveDeepDialog.ShowDialog() == DialogResult.OK)
                using (StreamWriter sw = new StreamWriter(saveDeepDialog.FileName))
                {
                    Thread.BeginCriticalRegion();
                    foreach (DeepPackage it in packMgr.MagBuf)
                    {
                        sw.Write(it.steering);
                        for (int i = 0; i < 6; ++i)
                        {
                            sw.Write(',');
                            sw.Write(it.sensor[i]);
                        }
                            sw.Write(',');
                        sw.WriteLine(it.sensor[6]);
                    }
                    Thread.EndCriticalRegion();
                }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.BeginCriticalRegion();
            packMgr.MagBuf.Clear();
            Thread.EndCriticalRegion();
        }

        int txLast, rxLast;
        private void timerTrans_Tick(object sender, EventArgs e)
        {
            lblRxBytes.Text = "已接收" + packMgr.rxCount.ToString() + "字节";
            lblTxBytes.Text = "已发送" + packMgr.txCount.ToString() + "字节";
            lblTxSpeed.Text = "发送速率：" + (packMgr.txCount - txLast).ToString() + "Bytes/s";
            lblRxSpeed.Text = "接收速率：" + (packMgr.rxCount - rxLast).ToString() + "Bytes/s";
            txLast = packMgr.txCount;
            rxLast = packMgr.rxCount;
        }
    }
}
