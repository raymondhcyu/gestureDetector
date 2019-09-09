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

/*  RESOURCES
 *  YouTube video of live data plotting: https://www.youtube.com/watch?v=nHyKfCn3zzM
 * 
 */

namespace Mech423Lab1
{
    public partial class mainForm : Form
    {
        // Create queues for x, y, and z data
        ConcurrentQueue<int> xDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> yDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> zDataQueue = new ConcurrentQueue<int>();

        // From YouTube tutorial:
        private Thread cpuThread;
        private double[] cpuArray = new double[60];

        private void getPerformanceCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor information", "% processor time", "_total");

            while(true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1); // clone cpuArray skipping first and last elements

                if(xyzChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateChart(); });
                }
                else
                {

                }

                Thread.Sleep(1000); // delay else updates too fast
            }
        }

        private void UpdateChart()
        {
            // For CPU usage
            /*xyzChart.Series["CPU Usage"].Points.Clear();

            for(int i = 0; i < cpuArray.Length; i++)
            {
                xyzChart.Series["CPU Usage"].Points.AddY(cpuArray[i]);
            }*/
        }

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
            // For CPU usage
            /*cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();*/

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
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close serial ports on exit
            if (serialCom.IsOpen)
                serialCom.Close();

            // Stop and exit
            Application.Exit();
        }

        private void SerialCom_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int bytesToRead;

            while ((serialCom.IsOpen) && (serialCom.BytesToRead > 0))
            {
                try
                {
                    if (serialCom.ReadByte() == 255) // check for start byte
                    {
                        bytesToRead = serialCom.ReadByte();
                        xDataQueue.Enqueue(bytesToRead); // xVal
                        bytesToRead = serialCom.ReadByte();
                        yDataQueue.Enqueue(bytesToRead); // yVal
                        bytesToRead = serialCom.ReadByte();
                        zDataQueue.Enqueue(bytesToRead); // zVal
                    }
                }
                catch (System.InvalidOperationException) // If serial is closed catch exception
                {
                    serialCom.Close();
                }
                catch (System.IO.IOException) // If serial is closed catch exception
                {
                    serialCom.Close();
                }
            }
        }

        private void TheTimer_Tick(object sender, EventArgs e)
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
                }

                yDataQueue.TryDequeue(out dataQueueOutput);
                yVal = dataQueueOutput;
                if (yVal != 0)
                {
                    yLabel.Text = dataQueueOutput.ToString();
                }

                zDataQueue.TryDequeue(out dataQueueOutput);
                zVal = dataQueueOutput;
                if (zVal != 0)
                {
                    zLabel.Text = dataQueueOutput.ToString();
                }
            }
        }
    }
}
