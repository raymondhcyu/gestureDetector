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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button2 = new System.Windows.Forms.Button();
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
            this.label13 = new System.Windows.Forms.Label();
            this.yawTextbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pitchTextbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rollTextbox = new System.Windows.Forms.TextBox();
            this.datalogCheckbox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xyzChart)).BeginInit();
            this.SuspendLayout();
            // 
            // serialConnectButton
            // 
            this.serialConnectButton.Location = new System.Drawing.Point(125, 13);
            this.serialConnectButton.Name = "serialConnectButton";
            this.serialConnectButton.Size = new System.Drawing.Size(83, 23);
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
            chartArea2.Name = "ChartArea1";
            this.xyzChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.xyzChart.Legends.Add(legend2);
            this.xyzChart.Location = new System.Drawing.Point(224, 12);
            this.xyzChart.Name = "xyzChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "X Accel";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Y Accel";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Z Accel";
            this.xyzChart.Series.Add(series4);
            this.xyzChart.Series.Add(series5);
            this.xyzChart.Series.Add(series6);
            this.xyzChart.Size = new System.Drawing.Size(726, 300);
            this.xyzChart.TabIndex = 3;
            this.xyzChart.Text = "chart1";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(867, 453);
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
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "REALTIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Z Accel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y Accel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "X Accel:";
            // 
            // zLabel
            // 
            this.zLabel.Location = new System.Drawing.Point(79, 147);
            this.zLabel.Name = "zLabel";
            this.zLabel.ReadOnly = true;
            this.zLabel.Size = new System.Drawing.Size(100, 22);
            this.zLabel.TabIndex = 10;
            // 
            // yLabel
            // 
            this.yLabel.Location = new System.Drawing.Point(79, 117);
            this.yLabel.Name = "yLabel";
            this.yLabel.ReadOnly = true;
            this.yLabel.Size = new System.Drawing.Size(100, 22);
            this.yLabel.TabIndex = 9;
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(79, 85);
            this.xLabel.Name = "xLabel";
            this.xLabel.ReadOnly = true;
            this.xLabel.Size = new System.Drawing.Size(100, 22);
            this.xLabel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Z Accel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Y Accel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "X Accel:";
            // 
            // zLabelAvg
            // 
            this.zLabelAvg.Location = new System.Drawing.Point(79, 284);
            this.zLabelAvg.Name = "zLabelAvg";
            this.zLabelAvg.ReadOnly = true;
            this.zLabelAvg.Size = new System.Drawing.Size(100, 22);
            this.zLabelAvg.TabIndex = 17;
            // 
            // yLabelAvg
            // 
            this.yLabelAvg.Location = new System.Drawing.Point(79, 254);
            this.yLabelAvg.Name = "yLabelAvg";
            this.yLabelAvg.ReadOnly = true;
            this.yLabelAvg.Size = new System.Drawing.Size(100, 22);
            this.yLabelAvg.TabIndex = 16;
            // 
            // xLabelAvg
            // 
            this.xLabelAvg.Location = new System.Drawing.Point(79, 222);
            this.xLabelAvg.Name = "xLabelAvg";
            this.xLabelAvg.ReadOnly = true;
            this.xLabelAvg.Size = new System.Drawing.Size(100, 22);
            this.xLabelAvg.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "AVERAGE";
            // 
            // saveToCSVButton
            // 
            this.saveToCSVButton.Location = new System.Drawing.Point(741, 453);
            this.saveToCSVButton.Name = "saveToCSVButton";
            this.saveToCSVButton.Size = new System.Drawing.Size(106, 23);
            this.saveToCSVButton.TabIndex = 21;
            this.saveToCSVButton.Text = "Save to CSV";
            this.saveToCSVButton.UseVisualStyleBackColor = true;
            this.saveToCSVButton.Click += new System.EventHandler(this.SaveToCSVButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Easter Egg";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Buffer Size:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Uptime:";
            // 
            // bufferSizeTextbox
            // 
            this.bufferSizeTextbox.Location = new System.Drawing.Point(550, 352);
            this.bufferSizeTextbox.Name = "bufferSizeTextbox";
            this.bufferSizeTextbox.ReadOnly = true;
            this.bufferSizeTextbox.Size = new System.Drawing.Size(100, 22);
            this.bufferSizeTextbox.TabIndex = 24;
            // 
            // uptimeTextbox
            // 
            this.uptimeTextbox.Location = new System.Drawing.Point(550, 322);
            this.uptimeTextbox.Name = "uptimeTextbox";
            this.uptimeTextbox.ReadOnly = true;
            this.uptimeTextbox.Size = new System.Drawing.Size(100, 22);
            this.uptimeTextbox.TabIndex = 23;
            // 
            // gestureLabel
            // 
            this.gestureLabel.AutoSize = true;
            this.gestureLabel.Location = new System.Drawing.Point(719, 383);
            this.gestureLabel.Name = "gestureLabel";
            this.gestureLabel.Size = new System.Drawing.Size(63, 17);
            this.gestureLabel.TabIndex = 30;
            this.gestureLabel.Text = "Gesture:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(668, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Accel Sequence:";
            // 
            // gestureTextbox
            // 
            this.gestureTextbox.Location = new System.Drawing.Point(788, 383);
            this.gestureTextbox.Name = "gestureTextbox";
            this.gestureTextbox.ReadOnly = true;
            this.gestureTextbox.Size = new System.Drawing.Size(162, 22);
            this.gestureTextbox.TabIndex = 28;
            // 
            // accelSequenceTextbox
            // 
            this.accelSequenceTextbox.Location = new System.Drawing.Point(788, 353);
            this.accelSequenceTextbox.Name = "accelSequenceTextbox";
            this.accelSequenceTextbox.ReadOnly = true;
            this.accelSequenceTextbox.Size = new System.Drawing.Size(162, 22);
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
            this.label11.Location = new System.Drawing.Point(685, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Current Accel:";
            // 
            // currentAccelTextbox
            // 
            this.currentAccelTextbox.Location = new System.Drawing.Point(788, 325);
            this.currentAccelTextbox.Name = "currentAccelTextbox";
            this.currentAccelTextbox.ReadOnly = true;
            this.currentAccelTextbox.Size = new System.Drawing.Size(162, 22);
            this.currentAccelTextbox.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Yaw:";
            // 
            // yawTextbox
            // 
            this.yawTextbox.Location = new System.Drawing.Point(108, 355);
            this.yawTextbox.Name = "yawTextbox";
            this.yawTextbox.ReadOnly = true;
            this.yawTextbox.Size = new System.Drawing.Size(100, 22);
            this.yawTextbox.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Pitch:";
            // 
            // pitchTextbox
            // 
            this.pitchTextbox.Location = new System.Drawing.Point(108, 383);
            this.pitchTextbox.Name = "pitchTextbox";
            this.pitchTextbox.ReadOnly = true;
            this.pitchTextbox.Size = new System.Drawing.Size(100, 22);
            this.pitchTextbox.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "Roll:";
            // 
            // rollTextbox
            // 
            this.rollTextbox.Location = new System.Drawing.Point(108, 411);
            this.rollTextbox.Name = "rollTextbox";
            this.rollTextbox.ReadOnly = true;
            this.rollTextbox.Size = new System.Drawing.Size(100, 22);
            this.rollTextbox.TabIndex = 40;
            // 
            // datalogCheckbox
            // 
            this.datalogCheckbox.AutoSize = true;
            this.datalogCheckbox.Location = new System.Drawing.Point(741, 426);
            this.datalogCheckbox.Name = "datalogCheckbox";
            this.datalogCheckbox.Size = new System.Drawing.Size(106, 21);
            this.datalogCheckbox.TabIndex = 42;
            this.datalogCheckbox.Text = "Datalogging";
            this.datalogCheckbox.UseVisualStyleBackColor = true;
            this.datalogCheckbox.CheckedChanged += new System.EventHandler(this.DatalogCheckbox_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 43;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 488);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datalogCheckbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rollTextbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pitchTextbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.yawTextbox);
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
            this.Controls.Add(this.button2);
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
            this.MinimumSize = new System.Drawing.Size(980, 480);
            this.Name = "mainForm";
            this.Text = "Accelerated Gestures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xyzChart)).EndInit();
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
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox yawTextbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pitchTextbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rollTextbox;
        private System.Windows.Forms.CheckBox datalogCheckbox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

