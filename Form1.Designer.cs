namespace UperMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series51 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series52 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series53 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series54 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series55 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series56 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.enPortCheckBox = new System.Windows.Forms.CheckBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRxBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTxBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRxSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTxSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendSpeed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSpeedKd = new System.Windows.Forms.NumericUpDown();
            this.numSpeedKi = new System.Windows.Forms.NumericUpDown();
            this.numSpeedKp = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSendSteer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numSteerKd = new System.Windows.Forms.NumericUpDown();
            this.numSteerKi = new System.Windows.Forms.NumericUpDown();
            this.numSteerKp = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblMaxSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSpeedL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpeedR = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.magChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.steerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richLogBox = new System.Windows.Forms.RichTextBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timerPlot = new System.Windows.Forms.Timer(this.components);
            this.timerTrans = new System.Windows.Forms.Timer(this.components);
            this.saveDeepDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedKp)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSteerKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSteerKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSteerKp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steerChart)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.BaudRate = 460800;
            this.port.ParityReplace = ((byte)(0));
            this.port.PortName = "COM9";
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // enPortCheckBox
            // 
            resources.ApplyResources(this.enPortCheckBox, "enPortCheckBox");
            this.enPortCheckBox.Name = "enPortCheckBox";
            this.enPortCheckBox.UseVisualStyleBackColor = true;
            this.enPortCheckBox.CheckedChanged += new System.EventHandler(this.enPortCheckBox_CheckedChanged);
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.portComboBox, "portComboBox");
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Items.AddRange(new object[] {
            resources.GetString("portComboBox.Items")});
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Sorted = true;
            // 
            // btnRefreshPorts
            // 
            resources.ApplyResources(this.btnRefreshPorts, "btnRefreshPorts");
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // baudComboBox
            // 
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Items.AddRange(new object[] {
            resources.GetString("baudComboBox.Items"),
            resources.GetString("baudComboBox.Items1"),
            resources.GetString("baudComboBox.Items2"),
            resources.GetString("baudComboBox.Items3"),
            resources.GetString("baudComboBox.Items4"),
            resources.GetString("baudComboBox.Items5")});
            resources.ApplyResources(this.baudComboBox, "baudComboBox");
            this.baudComboBox.Name = "baudComboBox";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRxBytes,
            this.lblTxBytes,
            this.lblRxSpeed,
            this.lblTxSpeed});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblRxBytes
            // 
            this.lblRxBytes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRxBytes.Name = "lblRxBytes";
            resources.ApplyResources(this.lblRxBytes, "lblRxBytes");
            // 
            // lblTxBytes
            // 
            this.lblTxBytes.Name = "lblTxBytes";
            resources.ApplyResources(this.lblTxBytes, "lblTxBytes");
            // 
            // lblRxSpeed
            // 
            this.lblRxSpeed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRxSpeed.Name = "lblRxSpeed";
            resources.ApplyResources(this.lblRxSpeed, "lblRxSpeed");
            // 
            // lblTxSpeed
            // 
            this.lblTxSpeed.Name = "lblTxSpeed";
            resources.ApplyResources(this.lblTxSpeed, "lblTxSpeed");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portComboBox);
            this.groupBox1.Controls.Add(this.btnRefreshPorts);
            this.groupBox1.Controls.Add(this.baudComboBox);
            this.groupBox1.Controls.Add(this.enPortCheckBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendSpeed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numSpeedKd);
            this.groupBox2.Controls.Add(this.numSpeedKi);
            this.groupBox2.Controls.Add(this.numSpeedKp);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnSendSpeed
            // 
            resources.ApplyResources(this.btnSendSpeed, "btnSendSpeed");
            this.btnSendSpeed.Name = "btnSendSpeed";
            this.btnSendSpeed.UseVisualStyleBackColor = true;
            this.btnSendSpeed.Click += new System.EventHandler(this.btnSendSpeed_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numSpeedKd
            // 
            resources.ApplyResources(this.numSpeedKd, "numSpeedKd");
            this.numSpeedKd.DecimalPlaces = 6;
            this.numSpeedKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSpeedKd.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numSpeedKd.Name = "numSpeedKd";
            // 
            // numSpeedKi
            // 
            resources.ApplyResources(this.numSpeedKi, "numSpeedKi");
            this.numSpeedKi.DecimalPlaces = 6;
            this.numSpeedKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numSpeedKi.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeedKi.Name = "numSpeedKi";
            // 
            // numSpeedKp
            // 
            resources.ApplyResources(this.numSpeedKp, "numSpeedKp");
            this.numSpeedKp.DecimalPlaces = 6;
            this.numSpeedKp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSpeedKp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeedKp.Name = "numSpeedKp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSendSteer);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numSteerKd);
            this.groupBox3.Controls.Add(this.numSteerKi);
            this.groupBox3.Controls.Add(this.numSteerKp);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnSendSteer
            // 
            resources.ApplyResources(this.btnSendSteer, "btnSendSteer");
            this.btnSendSteer.Name = "btnSendSteer";
            this.btnSendSteer.UseVisualStyleBackColor = true;
            this.btnSendSteer.Click += new System.EventHandler(this.btnSendSteer_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // numSteerKd
            // 
            resources.ApplyResources(this.numSteerKd, "numSteerKd");
            this.numSteerKd.DecimalPlaces = 6;
            this.numSteerKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSteerKd.Name = "numSteerKd";
            // 
            // numSteerKi
            // 
            resources.ApplyResources(this.numSteerKi, "numSteerKi");
            this.numSteerKi.DecimalPlaces = 6;
            this.numSteerKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSteerKi.Name = "numSteerKi";
            // 
            // numSteerKp
            // 
            resources.ApplyResources(this.numSteerKp, "numSteerKp");
            this.numSteerKp.DecimalPlaces = 6;
            this.numSteerKp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSteerKp.Name = "numSteerKp";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.statusStrip2);
            this.tabPage1.Controls.Add(this.speedChart);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMaxSpeed,
            this.toolStripDropDownButton1,
            this.lblSpeedL,
            this.lblSpeedR});
            resources.ApplyResources(this.statusStrip2, "statusStrip2");
            this.statusStrip2.Name = "statusStrip2";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            resources.ApplyResources(this.lblMaxSpeed, "lblMaxSpeed");
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // lblSpeedL
            // 
            this.lblSpeedL.Name = "lblSpeedL";
            resources.ApplyResources(this.lblSpeedL, "lblSpeedL");
            // 
            // lblSpeedR
            // 
            this.lblSpeedR.Name = "lblSpeedR";
            resources.ApplyResources(this.lblSpeedR, "lblSpeedR");
            // 
            // speedChart
            // 
            chartArea10.AxisX.Title = "时间";
            chartArea10.AxisY.IsStartedFromZero = false;
            chartArea10.AxisY.Title = "速度（cm/s）";
            chartArea10.AxisY2.IsMarginVisible = false;
            chartArea10.AxisY2.Maximum = 100D;
            chartArea10.AxisY2.Minimum = 0D;
            chartArea10.AxisY2.Title = "占空比（%）";
            chartArea10.Name = "ChartArea1";
            this.speedChart.ChartAreas.Add(chartArea10);
            resources.ApplyResources(this.speedChart, "speedChart");
            legend10.Name = "Legend1";
            this.speedChart.Legends.Add(legend10);
            this.speedChart.Name = "speedChart";
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series43.Legend = "Legend1";
            series43.Name = "LeftSpeedSeries";
            series43.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series44.Legend = "Legend1";
            series44.Name = "RightSpeedSeries";
            series44.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series45.Legend = "Legend1";
            series45.Name = "LeftDutySeries";
            series45.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series45.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series46.Legend = "Legend1";
            series46.Name = "RightDutySeries";
            series46.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series46.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.speedChart.Series.Add(series43);
            this.speedChart.Series.Add(series44);
            this.speedChart.Series.Add(series45);
            this.speedChart.Series.Add(series46);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.magChart);
            this.tabPage2.Controls.Add(this.menuStrip1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // magChart
            // 
            chartArea11.Name = "ChartArea1";
            this.magChart.ChartAreas.Add(chartArea11);
            resources.ApplyResources(this.magChart, "magChart");
            legend11.Name = "Legend1";
            this.magChart.Legends.Add(legend11);
            this.magChart.Name = "magChart";
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series47.Legend = "Legend1";
            series47.Name = "Series1";
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series48.Legend = "Legend1";
            series48.Name = "Series2";
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series49.Legend = "Legend1";
            series49.Name = "Series3";
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series50.Legend = "Legend1";
            series50.Name = "Series4";
            series51.ChartArea = "ChartArea1";
            series51.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series51.Legend = "Legend1";
            series51.Name = "Series5";
            series52.ChartArea = "ChartArea1";
            series52.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series52.Legend = "Legend1";
            series52.Name = "Series6";
            series53.ChartArea = "ChartArea1";
            series53.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series53.Legend = "Legend1";
            series53.Name = "Series7";
            series54.ChartArea = "ChartArea1";
            series54.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series54.Legend = "Legend1";
            series54.Name = "Series8";
            this.magChart.Series.Add(series47);
            this.magChart.Series.Add(series48);
            this.magChart.Series.Add(series49);
            this.magChart.Series.Add(series50);
            this.magChart.Series.Add(series51);
            this.magChart.Series.Add(series52);
            this.magChart.Series.Add(series53);
            this.magChart.Series.Add(series54);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.clearToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            resources.ApplyResources(this.保存ToolStripMenuItem, "保存ToolStripMenuItem");
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.steerChart);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // steerChart
            // 
            chartArea12.AxisY.IsStartedFromZero = false;
            chartArea12.AxisY2.IsStartedFromZero = false;
            chartArea12.Name = "ChartArea1";
            this.steerChart.ChartAreas.Add(chartArea12);
            resources.ApplyResources(this.steerChart, "steerChart");
            legend12.Name = "Legend1";
            this.steerChart.Legends.Add(legend12);
            this.steerChart.Name = "steerChart";
            this.steerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series55.ChartArea = "ChartArea1";
            series55.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series55.Legend = "Legend1";
            series55.Name = "InSeries";
            series55.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series56.ChartArea = "ChartArea1";
            series56.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series56.Legend = "Legend1";
            series56.Name = "OutSeries";
            this.steerChart.Series.Add(series55);
            this.steerChart.Series.Add(series56);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richLogBox);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richLogBox
            // 
            this.richLogBox.AutoWordSelection = true;
            resources.ApplyResources(this.richLogBox, "richLogBox");
            this.richLogBox.HideSelection = false;
            this.richLogBox.Name = "richLogBox";
            this.richLogBox.ReadOnly = true;
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            resources.GetString("checkedListBox.Items"),
            resources.GetString("checkedListBox.Items1"),
            resources.GetString("checkedListBox.Items2"),
            resources.GetString("checkedListBox.Items3"),
            resources.GetString("checkedListBox.Items4"),
            resources.GetString("checkedListBox.Items5"),
            resources.GetString("checkedListBox.Items6"),
            resources.GetString("checkedListBox.Items7")});
            resources.ApplyResources(this.checkedListBox, "checkedListBox");
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkedListBox);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // timerPlot
            // 
            this.timerPlot.Enabled = true;
            this.timerPlot.Interval = 666;
            this.timerPlot.Tick += new System.EventHandler(this.timerPlot_Tick);
            // 
            // timerTrans
            // 
            this.timerTrans.Enabled = true;
            this.timerTrans.Interval = 1000;
            this.timerTrans.Tick += new System.EventHandler(this.timerTrans_Tick);
            // 
            // saveDeepDialog
            // 
            this.saveDeepDialog.FileName = "顺时针";
            resources.ApplyResources(this.saveDeepDialog, "saveDeepDialog");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedKp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSteerKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSteerKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSteerKp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.steerChart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.IO.Ports.SerialPort port;
        private System.Windows.Forms.CheckBox enPortCheckBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.ComboBox baudComboBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRxBytes;
        private System.Windows.Forms.ToolStripStatusLabel lblTxBytes;
        private System.Windows.Forms.ToolStripStatusLabel lblRxSpeed;
        private System.Windows.Forms.ToolStripStatusLabel lblTxSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSpeedKd;
        private System.Windows.Forms.NumericUpDown numSpeedKi;
        private System.Windows.Forms.NumericUpDown numSpeedKp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSendSteer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSteerKd;
        private System.Windows.Forms.NumericUpDown numSteerKi;
        private System.Windows.Forms.NumericUpDown numSteerKp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart speedChart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart magChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart steerChart;
        public System.Windows.Forms.RichTextBox richLogBox;
        private System.Windows.Forms.Timer timerPlot;
        public System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel lblMaxSpeed;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Timer timerTrans;
        public System.Windows.Forms.ToolStripStatusLabel lblSpeedL;
        public System.Windows.Forms.ToolStripStatusLabel lblSpeedR;
        public System.Windows.Forms.SaveFileDialog saveDeepDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

