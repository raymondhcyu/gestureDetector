using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace Mech423Lab1
{
    public partial class mainForm : Form
    {
        const int chartMax = 100; // max intervals of live reading else appends to end
        const int avgAccelNum = 100; // take avg of last values
        int bytesInQueue;
        int timeCounter = 0;

        // Create queues for x, y, and z data, and running averages
        ConcurrentQueue<int> xDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> yDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> zDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> xDataQueueAvg = new ConcurrentQueue<int>();
        ConcurrentQueue<int> yDataQueueAvg = new ConcurrentQueue<int>();
        ConcurrentQueue<int> zDataQueueAvg = new ConcurrentQueue<int>();

        public mainForm()
        { 
            InitializeComponent();
            theTimer.Tick += new EventHandler(TheTimer_Tick);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populate serial port combobox with serial ports
            foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
            {
                serialComboBox.Items.Add(port);
            }
        }

        private void SerialConnectButton_Click(object sender, EventArgs e)
        {
            // Check if serial port is open already; close if it is
            if (serialCom.IsOpen)
            {
                serialCom.Close();
                serialConnectButton.Text = "Connect";
                theTimer.Enabled = false;
            }
            // Check if serial port is not open and nothing is selected
            else if ((serialCom.IsOpen == false) && (serialComboBox.SelectedIndex == -1))
            {
                MessageBox.Show("Select a COM port!");
            }
            // Connect normally
            else
            {
                serialCom.PortName = serialComboBox.SelectedItem.ToString();
                serialCom.Open();
                theTimer.Enabled = true; // enable timer only on powerup
                serialConnectButton.Text = "Disconnect";
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close serial ports on exit
            if (serialCom.IsOpen)
                serialCom.Close();

            // Stop and exit
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close serial ports on exit
            if (serialCom.IsOpen)
                serialCom.Close();

            // Stop and exit
            Application.Exit();
        }

        // Receive serial data and enqueue
        private void SerialCom_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int currentByte;
            bytesInQueue = 0;

            while ((serialCom.IsOpen) && (serialCom.BytesToRead > 0))
            {
                try
                {
                    if (serialCom.ReadByte() == 255) // check for start byte
                    {
                        currentByte = serialCom.ReadByte();
                        xDataQueue.Enqueue(currentByte); // xVal
                        xDataQueueAvg.Enqueue(currentByte); // xVal for averaging
                        bytesInQueue += xDataQueue.Count();

                        currentByte = serialCom.ReadByte();
                        yDataQueue.Enqueue(currentByte); // yVal
                        yDataQueueAvg.Enqueue(currentByte); // yVal for averaging
                        bytesInQueue += yDataQueue.Count();

                        currentByte = serialCom.ReadByte();
                        zDataQueue.Enqueue(currentByte); // zVal
                        zDataQueueAvg.Enqueue(currentByte); // zVal for averaging
                        bytesInQueue += zDataQueue.Count();
                    }
                    serialCom.DiscardInBuffer(); // remove unused data in serial buffer
                }
                catch (System.InvalidOperationException) // if serial is closed catch exception
                {
                    serialCom.Close();
                }
                catch (System.IO.IOException) // if serial is closed catch exception
                {
                    serialCom.Close();
                }
            }
        }

        private void TheTimer_Tick(object sender, EventArgs e)
        {
            int[] averages = new int[] { 0, 0, 0 };
            if (serialCom.IsOpen)
            {
                // Show bytes in queue
                bufferSizeTextbox.Text = (bytesInQueue).ToString();

                // Populate real time acceleration
                RealTimeAccel();

                // Get averages of last 100 elements
                AvgAccel(averages); // passed by object
                xLabelAvg.Text = averages[0].ToString();
                yLabelAvg.Text = averages[1].ToString();
                zLabelAvg.Text = averages[2].ToString();

                // Display uptime
                int minutes = ((timeCounter * theTimer.Interval / 1000) / 60);
                int seconds = ((timeCounter * theTimer.Interval / 1000) % 60);
                string uptime = minutes.ToString() + " min " + seconds.ToString() + " sec";

                uptimeTextbox.Text = uptime;
                timeCounter++;
            }
        }

        // Plot data to chart
        private void RealTimeAccel()
        {
            int dataQueueOutput; // dequeue holding variable
            int xVal;
            int yVal;
            int zVal;

            if (serialCom.IsOpen)
            {
                xDataQueue.TryDequeue(out dataQueueOutput);
                xVal = dataQueueOutput;
                if (xVal != 0) // ignore if 0
                {
                    xLabel.Text = dataQueueOutput.ToString();
                    xyzChart.Series["X Accel"].Points.AddY(xVal);
                }

                yDataQueue.TryDequeue(out dataQueueOutput);
                yVal = dataQueueOutput;
                if (yVal != 0)
                {
                    yLabel.Text = dataQueueOutput.ToString();
                    xyzChart.Series["Y Accel"].Points.AddY(yVal);
                }

                zDataQueue.TryDequeue(out dataQueueOutput);
                zVal = dataQueueOutput;
                if (zVal != 0)
                {
                    zLabel.Text = dataQueueOutput.ToString();
                    xyzChart.Series["Z Accel"].Points.AddY(zVal);
                }

                // Remove overflow of maximum chart limit
                if ((xyzChart.Series["X Accel"].Points.Count() >= chartMax) ||
                    (xyzChart.Series["Y Accel"].Points.Count() >= chartMax) ||
                    (xyzChart.Series["Z Accel"].Points.Count() >= chartMax))
                {
                    xyzChart.Series["X Accel"].Points.RemoveAt(0);
                    xyzChart.Series["Y Accel"].Points.RemoveAt(0);
                    xyzChart.Series["Z Accel"].Points.RemoveAt(0);
                }
            }
        }

        // Display average x, y, z accelerations; avg passed by reference
        private void AvgAccel(int[] avg)
        {
            int[] sum = new int[] { 0, 0, 0 };
            int currentVal;

            // Dequeue anything over 100
            while (xDataQueueAvg.Count() > avgAccelNum)
            {
                xDataQueueAvg.TryDequeue(out currentVal);
            }
            while (yDataQueueAvg.Count() > avgAccelNum)
            {
                yDataQueueAvg.TryDequeue(out currentVal);
            }
            while (zDataQueueAvg.Count() > avgAccelNum)
            {
                zDataQueueAvg.TryDequeue(out currentVal);
            }

            // Calculate X averages
            foreach (int i in xDataQueueAvg)
            {
                sum[0] += i;
            }

            // Calculate Y averages
            foreach (int i in yDataQueueAvg)
            {
                sum[1] += i;
            }

            // Calculate Z averages
            foreach (int i in zDataQueueAvg)
            {
                sum[2] += i;
            }

            // Get averages
            for (int i = 0; i < avg.Length; i++)
            {
                avg[i] = sum[i] / avgAccelNum;
            }

            // Why doesn't this work??
            //foreach (int i in avg)
            //{
            //    if (avg.Length == sum.Length)
            //        MessageBox.Show("Same!");
            //    avg[i] = sum[i] / avgAccelNum;
            //}
        }
    }
}
