namespace Mech423Lab1
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialConnectButton = new System.Windows.Forms.Button();
            this.serialComboBox = new System.Windows.Forms.ComboBox();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.serialCom = new System.IO.Ports.SerialPort(this.components);
            this.xyzChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.zLabelAvg = new System.Windows.Forms.TextBox();
            this.yLabelAvg = new System.Windows.Forms.TextBox();
            this.xLabelAvg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveToCSVButton = new System.Windows.Forms.Button();
            this.easterEggButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bufferSizeTextbox = new System.Windows.Forms.TextBox();
            this.uptimeTextbox = new System.Windows.Forms.TextBox();
            this.gestureLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gestureTextbox = new System.Windows.Forms.TextBox();
            this.accelSequenceTextbox = new System.Windows.Forms.TextBox();
            this.orientationLabel = new System.Windows.Forms.Label();
            this.orientationTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.currentAccelTextbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pitchTextbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rollTextbox = new System.Windows.Forms.TextBox();
            this.datalogCheckbox = new System.Windows.Forms.CheckBox();
            this.orientPicBoxPitch = new System.Windows.Forms.PictureBox();
            this.orientPicBoxRoll = new System.Windows.Forms.PictureBox();
            this.gameLabel = new System.Windows.Forms.Label();
            this.gameGestureTextbox = new System.Windows.Forms.TextBox();
            this.gameReset = new System.Windows.Forms.Button();
            this.gameWonLabel = new System.Windows.Forms.Label();
            this.orientPicBoxYaw = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bytesToReadTextbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gravZTextbox = new System.Windows.Forms.TextBox();
            this.gravYTextbox = new System.Windows.Forms.TextBox();
            this.gravXTextbox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gravTotalTextbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.zBufferTextbox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.yBufferTextbox = new System.Windows.Forms.TextBox();
            this.xBufferTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xyzChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientPicBoxPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientPicBoxRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientPicBoxYaw)).BeginInit();
            this.SuspendLayout();
            // 
            // serialConnectButton
            // 
            this.serialConnectButton.Location = new System.Drawing.Point(115, 13);
            this.serialConnectButton.Name = "serialConnectButton";
            this.serialConnectButton.Size = new System.Drawing.Size(93, 23);
            this.serialConnectButton.TabIndex = 1;
            this.serialConnectButton.Text = "Connect";
            this.serialConnectButton.UseVisualStyleBackColor = true;
            this.serialConnectButton.Click += new System.EventHandler(this.SerialConnectButton_Click);
            // 
            // serialComboBox
            // 
            this.serialComboBox.FormattingEnabled = true;
            this.serialComboBox.Location = new System.Drawing.Point(12, 12);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(97, 24);
            this.serialComboBox.TabIndex = 2;
            // 
            // theTimer
            // 
            this.theTimer.Interval = 20;
            this.theTimer.Tick += new System.EventHandler(this.TheTimer_Tick);
            // 
            // serialCom
            // 
            this.serialCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialCom_DataReceived);
            // 
            // xyzChart
            // 
            this.xyzChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.xyzChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.xyzChart.Legends.Add(legend3);
            this.xyzChart.Location = new System.Drawing.Point(224, 12);
            this.xyzChart.Name = "xyzChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "X Accel";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Y Accel";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Z Accel";
            this.xyzChart.Series.Add(series7);
            this.xyzChart.Series.Add(series8);
            this.xyzChart.Series.Add(series9);
            this.xyzChart.Size = new System.Drawing.Size(896, 300);
            this.xyzChart.TabIndex = 3;
            this.xyzChart.Text = "chart1";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(1037, 608);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "REALTIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Z Accel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y Accel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "X Accel:";
            // 
            // zLabel
            // 
            this.zLabel.Location = new System.Drawing.Point(82, 131);
            this.zLabel.Name = "zLabel";
            this.zLabel.ReadOnly = true;
            this.zLabel.Size = new System.Drawing.Size(100, 22);
            this.zLabel.TabIndex = 10;
            // 
            // yLabel
            // 
            this.yLabel.Location = new System.Drawing.Point(82, 101);
            this.yLabel.Name = "yLabel";
            this.yLabel.ReadOnly = true;
            this.yLabel.Size = new System.Drawing.Size(100, 22);
            this.yLabel.TabIndex = 9;
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(82, 69);
            this.xLabel.Name = "xLabel";
            this.xLabel.ReadOnly = true;
            this.xLabel.Size = new System.Drawing.Size(100, 22);
            this.xLabel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Z:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "X:";
            // 
            // zLabelAvg
            // 
            this.zLabelAvg.Location = new System.Drawing.Point(82, 242);
            this.zLabelAvg.Name = "zLabelAvg";
            this.zLabelAvg.ReadOnly = true;
            this.zLabelAvg.Size = new System.Drawing.Size(100, 22);
            this.zLabelAvg.TabIndex = 17;
            // 
            // yLabelAvg
            // 
            this.yLabelAvg.Location = new System.Drawing.Point(82, 212);
            this.yLabelAvg.Name = "yLabelAvg";
            this.yLabelAvg.ReadOnly = true;
            this.yLabelAvg.Size = new System.Drawing.Size(100, 22);
            this.yLabelAvg.TabIndex = 16;
            // 
            // xLabelAvg
            // 
            this.xLabelAvg.Location = new System.Drawing.Point(82, 180);
            this.xLabelAvg.Name = "xLabelAvg";
            this.xLabelAvg.ReadOnly = true;
            this.xLabelAvg.Size = new System.Drawing.Size(100, 22);
            this.xLabelAvg.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "STD DEVS";
            // 
            // saveToCSVButton
            // 
            this.saveToCSVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveToCSVButton.Location = new System.Drawing.Point(909, 608);
            this.saveToCSVButton.Name = "saveToCSVButton";
            this.saveToCSVButton.Size = new System.Drawing.Size(106, 23);
            this.saveToCSVButton.TabIndex = 21;
            this.saveToCSVButton.Text = "Save to CSV";
            this.saveToCSVButton.UseVisualStyleBackColor = true;
            this.saveToCSVButton.Click += new System.EventHandler(this.SaveToCSVButton_Click);
            // 
            // easterEggButton
            // 
            this.easterEggButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.easterEggButton.Location = new System.Drawing.Point(785, 599);
            this.easterEggButton.Name = "easterEggButton";
            this.easterEggButton.Size = new System.Drawing.Size(103, 32);
            this.easterEggButton.TabIndex = 22;
            this.easterEggButton.Text = "Easter Egg";
            this.easterEggButton.UseVisualStyleBackColor = true;
            this.easterEggButton.Click += new System.EventHandler(this.EasterEggButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Buffer Size:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(768, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Uptime:";
            // 
            // bufferSizeTextbox
            // 
            this.bufferSizeTextbox.Location = new System.Drawing.Point(833, 357);
            this.bufferSizeTextbox.Name = "bufferSizeTextbox";
            this.bufferSizeTextbox.ReadOnly = true;
            this.bufferSizeTextbox.Size = new System.Drawing.Size(100, 22);
            this.bufferSizeTextbox.TabIndex = 24;
            // 
            // uptimeTextbox
            // 
            this.uptimeTextbox.Location = new System.Drawing.Point(833, 327);
            this.uptimeTextbox.Name = "uptimeTextbox";
            this.uptimeTextbox.ReadOnly = true;
            this.uptimeTextbox.Size = new System.Drawing.Size(100, 22);
            this.uptimeTextbox.TabIndex = 23;
            // 
            // gestureLabel
            // 
            this.gestureLabel.AutoSize = true;
            this.gestureLabel.Location = new System.Drawing.Point(492, 383);
            this.gestureLabel.Name = "gestureLabel";
            this.gestureLabel.Size = new System.Drawing.Size(63, 17);
            this.gestureLabel.TabIndex = 30;
            this.gestureLabel.Text = "Gesture:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Accel Sequence:";
            // 
            // gestureTextbox
            // 
            this.gestureTextbox.Location = new System.Drawing.Point(561, 383);
            this.gestureTextbox.Name = "gestureTextbox";
            this.gestureTextbox.ReadOnly = true;
            this.gestureTextbox.Size = new System.Drawing.Size(148, 22);
            this.gestureTextbox.TabIndex = 28;
            // 
            // accelSequenceTextbox
            // 
            this.accelSequenceTextbox.Location = new System.Drawing.Point(561, 353);
            this.accelSequenceTextbox.Name = "accelSequenceTextbox";
            this.accelSequenceTextbox.ReadOnly = true;
            this.accelSequenceTextbox.Size = new System.Drawing.Size(148, 22);
            this.accelSequenceTextbox.TabIndex = 27;
            // 
            // orientationLabel
            // 
            this.orientationLabel.AutoSize = true;
            this.orientationLabel.Location = new System.Drawing.Point(221, 325);
            this.orientationLabel.Name = "orientationLabel";
            this.orientationLabel.Size = new System.Drawing.Size(82, 17);
            this.orientationLabel.TabIndex = 32;
            this.orientationLabel.Text = "Orientation:";
            // 
            // orientationTextbox
            // 
            this.orientationTextbox.Location = new System.Drawing.Point(317, 325);
            this.orientationTextbox.Name = "orientationTextbox";
            this.orientationTextbox.ReadOnly = true;
            this.orientationTextbox.Size = new System.Drawing.Size(100, 22);
            this.orientationTextbox.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Current Accel:";
            // 
            // currentAccelTextbox
            // 
            this.currentAccelTextbox.Location = new System.Drawing.Point(561, 325);
            this.currentAccelTextbox.Name = "currentAccelTextbox";
            this.currentAccelTextbox.ReadOnly = true;
            this.currentAccelTextbox.Size = new System.Drawing.Size(148, 22);
            this.currentAccelTextbox.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Pitch:";
            // 
            // pitchTextbox
            // 
            this.pitchTextbox.Location = new System.Drawing.Point(317, 355);
            this.pitchTextbox.Name = "pitchTextbox";
            this.pitchTextbox.ReadOnly = true;
            this.pitchTextbox.Size = new System.Drawing.Size(100, 22);
            this.pitchTextbox.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(267, 383);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "Roll:";
            // 
            // rollTextbox
            // 
            this.rollTextbox.Location = new System.Drawing.Point(317, 383);
            this.rollTextbox.Name = "rollTextbox";
            this.rollTextbox.ReadOnly = true;
            this.rollTextbox.Size = new System.Drawing.Size(100, 22);
            this.rollTextbox.TabIndex = 40;
            // 
            // datalogCheckbox
            // 
            this.datalogCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.datalogCheckbox.AutoSize = true;
            this.datalogCheckbox.Location = new System.Drawing.Point(909, 581);
            this.datalogCheckbox.Name = "datalogCheckbox";
            this.datalogCheckbox.Size = new System.Drawing.Size(106, 21);
            this.datalogCheckbox.TabIndex = 42;
            this.datalogCheckbox.Text = "Datalogging";
            this.datalogCheckbox.UseVisualStyleBackColor = true;
            this.datalogCheckbox.CheckedChanged += new System.EventHandler(this.DatalogCheckbox_CheckedChanged);
            // 
            // orientPicBoxPitch
            // 
            this.orientPicBoxPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orientPicBoxPitch.Location = new System.Drawing.Point(17, 424);
            this.orientPicBoxPitch.Margin = new System.Windows.Forms.Padding(4);
            this.orientPicBoxPitch.Name = "orientPicBoxPitch";
            this.orientPicBoxPitch.Size = new System.Drawing.Size(214, 202);
            this.orientPicBoxPitch.TabIndex = 43;
            this.orientPicBoxPitch.TabStop = false;
            // 
            // orientPicBoxRoll
            // 
            this.orientPicBoxRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orientPicBoxRoll.Location = new System.Drawing.Point(254, 424);
            this.orientPicBoxRoll.Margin = new System.Windows.Forms.Padding(4);
            this.orientPicBoxRoll.Name = "orientPicBoxRoll";
            this.orientPicBoxRoll.Size = new System.Drawing.Size(214, 202);
            this.orientPicBoxRoll.TabIndex = 44;
            this.orientPicBoxRoll.TabStop = false;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(841, 449);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(203, 17);
            this.gameLabel.TabIndex = 45;
            this.gameLabel.Text = "Try getting the correct gesture!";
            this.gameLabel.Visible = false;
            // 
            // gameGestureTextbox
            // 
            this.gameGestureTextbox.Location = new System.Drawing.Point(841, 479);
            this.gameGestureTextbox.Name = "gameGestureTextbox";
            this.gameGestureTextbox.ReadOnly = true;
            this.gameGestureTextbox.Size = new System.Drawing.Size(203, 22);
            this.gameGestureTextbox.TabIndex = 46;
            this.gameGestureTextbox.Visible = false;
            // 
            // gameReset
            // 
            this.gameReset.Location = new System.Drawing.Point(969, 516);
            this.gameReset.Name = "gameReset";
            this.gameReset.Size = new System.Drawing.Size(75, 23);
            this.gameReset.TabIndex = 47;
            this.gameReset.Text = "Reset";
            this.gameReset.UseVisualStyleBackColor = true;
            this.gameReset.Visible = false;
            this.gameReset.Click += new System.EventHandler(this.GameReset_Click);
            // 
            // gameWonLabel
            // 
            this.gameWonLabel.AutoSize = true;
            this.gameWonLabel.Location = new System.Drawing.Point(841, 516);
            this.gameWonLabel.Name = "gameWonLabel";
            this.gameWonLabel.Size = new System.Drawing.Size(65, 17);
            this.gameWonLabel.TabIndex = 48;
            this.gameWonLabel.Text = "You won!";
            this.gameWonLabel.Visible = false;
            // 
            // orientPicBoxYaw
            // 
            this.orientPicBoxYaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orientPicBoxYaw.Location = new System.Drawing.Point(495, 424);
            this.orientPicBoxYaw.Margin = new System.Windows.Forms.Padding(4);
            this.orientPicBoxYaw.Name = "orientPicBoxYaw";
            this.orientPicBoxYaw.Size = new System.Drawing.Size(214, 202);
            this.orientPicBoxYaw.TabIndex = 49;
            this.orientPicBoxYaw.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(728, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 51;
            this.label13.Text = "Bytes to read:";
            // 
            // bytesToReadTextbox
            // 
            this.bytesToReadTextbox.Location = new System.Drawing.Point(833, 385);
            this.bytesToReadTextbox.Name = "bytesToReadTextbox";
            this.bytesToReadTextbox.ReadOnly = true;
            this.bytesToReadTextbox.Size = new System.Drawing.Size(100, 22);
            this.bytesToReadTextbox.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 17);
            this.label16.TabIndex = 59;
            this.label16.Text = "Z:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 328);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 17);
            this.label17.TabIndex = 58;
            this.label17.Text = "Y:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 301);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 17);
            this.label18.TabIndex = 57;
            this.label18.Text = "X:";
            // 
            // gravZTextbox
            // 
            this.gravZTextbox.Location = new System.Drawing.Point(82, 358);
            this.gravZTextbox.Name = "gravZTextbox";
            this.gravZTextbox.ReadOnly = true;
            this.gravZTextbox.Size = new System.Drawing.Size(100, 22);
            this.gravZTextbox.TabIndex = 56;
            // 
            // gravYTextbox
            // 
            this.gravYTextbox.Location = new System.Drawing.Point(82, 328);
            this.gravYTextbox.Name = "gravYTextbox";
            this.gravYTextbox.ReadOnly = true;
            this.gravYTextbox.Size = new System.Drawing.Size(100, 22);
            this.gravYTextbox.TabIndex = 55;
            // 
            // gravXTextbox
            // 
            this.gravXTextbox.Location = new System.Drawing.Point(82, 296);
            this.gravXTextbox.Name = "gravXTextbox";
            this.gravXTextbox.ReadOnly = true;
            this.gravXTextbox.Size = new System.Drawing.Size(100, 22);
            this.gravXTextbox.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 17);
            this.label19.TabIndex = 53;
            this.label19.Text = "GRAVITY";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 386);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 61;
            this.label20.Text = "Total:";
            // 
            // gravTotalTextbox
            // 
            this.gravTotalTextbox.Location = new System.Drawing.Point(82, 386);
            this.gravTotalTextbox.Name = "gravTotalTextbox";
            this.gravTotalTextbox.ReadOnly = true;
            this.gravTotalTextbox.Size = new System.Drawing.Size(100, 22);
            this.gravTotalTextbox.TabIndex = 60;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(951, 388);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 67;
            this.label21.Text = "Z Buffer:";
            // 
            // zBufferTextbox
            // 
            this.zBufferTextbox.Location = new System.Drawing.Point(1020, 386);
            this.zBufferTextbox.Name = "zBufferTextbox";
            this.zBufferTextbox.ReadOnly = true;
            this.zBufferTextbox.Size = new System.Drawing.Size(100, 22);
            this.zBufferTextbox.TabIndex = 66;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(951, 360);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 17);
            this.label22.TabIndex = 65;
            this.label22.Text = "Y Buffer:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(951, 331);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 17);
            this.label23.TabIndex = 64;
            this.label23.Text = "X Buffer:";
            // 
            // yBufferTextbox
            // 
            this.yBufferTextbox.Location = new System.Drawing.Point(1020, 358);
            this.yBufferTextbox.Name = "yBufferTextbox";
            this.yBufferTextbox.ReadOnly = true;
            this.yBufferTextbox.Size = new System.Drawing.Size(100, 22);
            this.yBufferTextbox.TabIndex = 63;
            // 
            // xBufferTextbox
            // 
            this.xBufferTextbox.Location = new System.Drawing.Point(1020, 328);
            this.xBufferTextbox.Name = "xBufferTextbox";
            this.xBufferTextbox.ReadOnly = true;
            this.xBufferTextbox.Size = new System.Drawing.Size(100, 22);
            this.xBufferTextbox.TabIndex = 62;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 643);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.zBufferTextbox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.yBufferTextbox);
            this.Controls.Add(this.xBufferTextbox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.gravTotalTextbox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gravZTextbox);
            this.Controls.Add(this.gravYTextbox);
            this.Controls.Add(this.gravXTextbox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bytesToReadTextbox);
            this.Controls.Add(this.orientPicBoxYaw);
            this.Controls.Add(this.gameWonLabel);
            this.Controls.Add(this.gameReset);
            this.Controls.Add(this.gameGestureTextbox);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.orientPicBoxRoll);
            this.Controls.Add(this.orientPicBoxPitch);
            this.Controls.Add(this.datalogCheckbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rollTextbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pitchTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.currentAccelTextbox);
            this.Controls.Add(this.orientationLabel);
            this.Controls.Add(this.orientationTextbox);
            this.Controls.Add(this.gestureLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gestureTextbox);
            this.Controls.Add(this.accelSequenceTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bufferSizeTextbox);
            this.Controls.Add(this.uptimeTextbox);
            this.Controls.Add(this.easterEggButton);
            this.Controls.Add(this.saveToCSVButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zLabelAvg);
            this.Controls.Add(this.yLabelAvg);
            this.Controls.Add(this.xLabelAvg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.xyzChart);
            this.Controls.Add(this.serialComboBox);
            this.Controls.Add(this.serialConnectButton);
            this.MinimumSize = new System.Drawing.Size(1150, 690);
            this.Name = "mainForm";
            this.Text = "Accelerated Gestures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xyzChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientPicBoxPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientPicBoxRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientPicBoxYaw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button serialConnectButton;
        private System.Windows.Forms.ComboBox serialComboBox;
        private System.Windows.Forms.Timer theTimer;
        private System.IO.Ports.SerialPort serialCom;
        private System.Windows.Forms.DataVisualization.Charting.Chart xyzChart;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zLabel;
        private System.Windows.Forms.TextBox yLabel;
        private System.Windows.Forms.TextBox xLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zLabelAvg;
        private System.Windows.Forms.TextBox yLabelAvg;
        private System.Windows.Forms.TextBox xLabelAvg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveToCSVButton;
        private System.Windows.Forms.Button easterEggButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bufferSizeTextbox;
        private System.Windows.Forms.TextBox uptimeTextbox;
        private System.Windows.Forms.Label gestureLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox gestureTextbox;
        private System.Windows.Forms.TextBox accelSequenceTextbox;
        private System.Windows.Forms.Label orientationLabel;
        private System.Windows.Forms.TextBox orientationTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox currentAccelTextbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pitchTextbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rollTextbox;
        private System.Windows.Forms.CheckBox datalogCheckbox;
        private System.Windows.Forms.PictureBox orientPicBoxPitch;
        private System.Windows.Forms.PictureBox orientPicBoxRoll;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.TextBox gameGestureTextbox;
        private System.Windows.Forms.Button gameReset;
        private System.Windows.Forms.Label gameWonLabel;
        private System.Windows.Forms.PictureBox orientPicBoxYaw;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bytesToReadTextbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox gravZTextbox;
        private System.Windows.Forms.TextBox gravYTextbox;
        private System.Windows.Forms.TextBox gravXTextbox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox gravTotalTextbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox zBufferTextbox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox yBufferTextbox;
        private System.Windows.Forms.TextBox xBufferTextbox;
    }
}

