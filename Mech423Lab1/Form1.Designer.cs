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
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bufferSizeTextbox = new System.Windows.Forms.TextBox();
            this.uptimeTextbox = new System.Windows.Forms.TextBox();
            this.gestureTextbox = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.accelSequenceTextbox = new System.Windows.Forms.TextBox();
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
            this.theTimer.Interval = 10;
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
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "X Accel";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Y Accel";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Z Accel";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "CPU Usage";
            this.xyzChart.Series.Add(series5);
            this.xyzChart.Series.Add(series6);
            this.xyzChart.Series.Add(series7);
            this.xyzChart.Series.Add(series8);
            this.xyzChart.Size = new System.Drawing.Size(496, 300);
            this.xyzChart.TabIndex = 3;
            this.xyzChart.Text = "chart1";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(637, 398);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Buffer Size:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Uptime:";
            // 
            // bufferSizeTextbox
            // 
            this.bufferSizeTextbox.Location = new System.Drawing.Point(320, 352);
            this.bufferSizeTextbox.Name = "bufferSizeTextbox";
            this.bufferSizeTextbox.ReadOnly = true;
            this.bufferSizeTextbox.Size = new System.Drawing.Size(100, 22);
            this.bufferSizeTextbox.TabIndex = 24;
            // 
            // uptimeTextbox
            // 
            this.uptimeTextbox.Location = new System.Drawing.Point(320, 322);
            this.uptimeTextbox.Name = "uptimeTextbox";
            this.uptimeTextbox.ReadOnly = true;
            this.uptimeTextbox.Size = new System.Drawing.Size(100, 22);
            this.uptimeTextbox.TabIndex = 23;
            // 
            // gestureTextbox
            // 
            this.gestureTextbox.AutoSize = true;
            this.gestureTextbox.Location = new System.Drawing.Point(489, 355);
            this.gestureTextbox.Name = "gestureTextbox";
            this.gestureTextbox.Size = new System.Drawing.Size(63, 17);
            this.gestureTextbox.TabIndex = 30;
            this.gestureTextbox.Text = "Gesture:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Accel Sequence:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(558, 355);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(162, 22);
            this.textBox3.TabIndex = 28;
            // 
            // accelSequenceTextbox
            // 
            this.accelSequenceTextbox.Location = new System.Drawing.Point(558, 325);
            this.accelSequenceTextbox.Name = "accelSequenceTextbox";
            this.accelSequenceTextbox.ReadOnly = true;
            this.accelSequenceTextbox.Size = new System.Drawing.Size(162, 22);
            this.accelSequenceTextbox.TabIndex = 27;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 433);
            this.Controls.Add(this.gestureTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.accelSequenceTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bufferSizeTextbox);
            this.Controls.Add(this.uptimeTextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.MinimumSize = new System.Drawing.Size(750, 480);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bufferSizeTextbox;
        private System.Windows.Forms.TextBox uptimeTextbox;
        private System.Windows.Forms.Label gestureTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox accelSequenceTextbox;
    }
}

