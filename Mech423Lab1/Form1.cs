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
using System.Media;
using System.Drawing.Drawing2D;

namespace Mech423Lab1
{
    public partial class mainForm : Form
    {
        // Accel class to pass accelerations to detect orientation
        class accel
        {
            public int x;
            public int y;
            public int z;
            public accel() // default constructor to zero
            {
                x = 0;
                y = 0;
                z = 0;
            }
        }

        class ypr
        {
            public double yaw;
            public double pitch;
            public double roll;

            public ypr() // default constructor
            {
                yaw = 0;
                pitch = 0;
                roll = 0;
            }
        }

        const int chartMax = 100; // max intervals of live reading else appends to end
        const int avgAccelNum = 100; // take avg of last values
        const int orientHighThresh = 145;
        const int orientLowThresh = 105;
        const int gestureThresh = 180;
        const int gestureThreshNeg = 120;
        const int gestureDisplayLimit = 1000; // 1000ms to display gesture
        const int gestureCheckLimit = 2000; // 2000ms to check for new gesture

        int bytesInQueue;
        string gestureState = ""; // global variable to set gestures
        int gestureCount = 0; // number of gestures detected
        int[] averages = new int[] { 0, 0, 0 };
        string fileName = ""; // trigger to check if DialogBox.FileName is initialized

        bool gameState = false; // display game gestures (cheat way of not using more logic)
        string gameString = ""; // another cheat way to pass displayCombo into game
        bool gameWon = false; // more cheat way

        accel accData = new accel(); // create new object accData to pass around
        ypr YPR = new ypr(); // create new object YPR to pass around
        Stopwatch uptimeTimer = new Stopwatch(); // timer for uptime
        Stopwatch gestureTimer = new Stopwatch(); // timer for gestures
        Bitmap pitchLevel, pitchUp, pitchDown, pitchInverted, rollLevel, rollLeft, rollRight, rollInverted;

        // Create queues for x, y, and z data
        ConcurrentQueue<int> xDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> yDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> zDataQueue = new ConcurrentQueue<int>();

        // Queues for average data
        ConcurrentQueue<int> xDataQueueAvg = new ConcurrentQueue<int>();
        ConcurrentQueue<int> yDataQueueAvg = new ConcurrentQueue<int>();
        ConcurrentQueue<int> zDataQueueAvg = new ConcurrentQueue<int>();

        // Queues for gestures and datalogging
        ConcurrentQueue<string> gestureQueue = new ConcurrentQueue<string>();
        ConcurrentQueue<string> dataLogQueue = new ConcurrentQueue<string>();

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

            // Load images for orientation
            pitchLevel = new Bitmap(@"C:\Users\Safet\source\repos\Mech423Lab1\pitchLevel.png");
            pitchUp = new Bitmap(@"C:\Users\Safet\source\repos\Mech423Lab1\pitchUp.png");
            pitchDown = new Bitmap(@"C:\Users\Safet\source\repos\Mech423Lab1\pitchDown.png");
            pitchInverted = new Bitmap(@"C:\Users\Safet\source\repos\Mech423Lab1\pitchInverted.png");
            rollLevel = new Bitmap(@"C:\Users\Safet\source\repos\Mech423Lab1\rollLevel.png");
            rollLeft = new Bitmap(@"C:\Users\Safet\source\repos\Mech423Lab1\rollLeft.png");
            rollRight = new Bitmap(@"C:\Users\Safet\source\repos\Mech423Lab1\rollRight.png");
            rollInverted = new Bitmap(@"C:\Users\Safet\source\repos\Mech423Lab1\rollInverted.png");
            orientPicBoxPitch.SizeMode = PictureBoxSizeMode.StretchImage;
            orientPicBoxRoll.SizeMode = PictureBoxSizeMode.StretchImage;
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

                // Start uptime stopwatch
                uptimeTimer.Restart();
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

            if (serialCom.IsOpen)
            {
                // Show bytes in queue
                bufferSizeTextbox.Text = (bytesInQueue).ToString();

                // Populate real time acceleration
                RealTimeAccel();

                // Get board orientation
                GetOrientation();

                // Get gestures
                GetGesture();

                // Display uptime
                int time = System.Convert.ToInt32(uptimeTimer.Elapsed.TotalSeconds);
                int seconds = time % 60;
                int minutes = time / 60;
                uptimeTextbox.Text = string.Format("{0:00}:{1:00}", minutes, seconds).ToString();

                // Gesture check logic
                if (gestureTimer.Elapsed.TotalMilliseconds > gestureDisplayLimit)
                {
                    if ((gestureState == "") && (gestureCount != 0))
                    {
                        gestureCount = 0; // reset gesture count

                        // Dequeue gesture queue since reset
                        while (!gestureQueue.IsEmpty)
                        {
                            string temp = "";
                            gestureQueue.TryDequeue(out temp);
                        }
                    }

                    gestureState = ""; // reset gesture
                    DisplayGesture();
                    DisplayCombo(false);

                    if (gestureCount != 0) // restart timer if gesture detected
                    {
                        gestureTimer.Restart();
                    }
                    else
                    {
                        gestureTimer.Stop();
                        gestureTimer.Reset();
                    }
                }

                // Get averages of last 100 elements
                AvgAccel(averages); // passed by object
                xLabelAvg.Text = averages[0].ToString();
                yLabelAvg.Text = averages[1].ToString();
                zLabelAvg.Text = averages[2].ToString();

                // Write to CSV
                if ((datalogCheckbox.Checked) && (fileName != ""))
                {
                    addRecord(accData.x, accData.y, accData.z, fileName);
                }

                // Display yaw pitch roll angles
                GetYPR();

                // Easter egg
                if (gameLabel.Visible == true)
                {
                    EasterEggGame();
                }
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
                    accData.x = dataQueueOutput; // for orientation
                    xLabel.Text = dataQueueOutput.ToString(); // display
                    xyzChart.Series["X Accel"].Points.AddY(xVal);
                }

                yDataQueue.TryDequeue(out dataQueueOutput);
                yVal = dataQueueOutput;
                if (yVal != 0)
                {
                    accData.y = dataQueueOutput;
                    yLabel.Text = dataQueueOutput.ToString();
                    xyzChart.Series["Y Accel"].Points.AddY(yVal);
                }

                zDataQueue.TryDequeue(out dataQueueOutput);
                zVal = dataQueueOutput;
                if (zVal != 0)
                {
                    accData.z = dataQueueOutput;
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
        }

        // Check accelerations and display orientation
        private void GetOrientation()
        {
            if (accData.x > orientHighThresh) // if x axis large then left roll
            {
                orientationTextbox.Text = "Roll left";
                orientPicBoxPitch.Image = pitchLevel;
                orientPicBoxRoll.Image = rollLeft;
            }
            else if (accData.x < orientLowThresh)
            {
                orientationTextbox.Text = "Roll right";
                orientPicBoxPitch.Image = pitchLevel;
                orientPicBoxRoll.Image = rollRight;
            }
            else if (accData.y > orientHighThresh)
            {
                orientationTextbox.Text = "Pitch up";
                orientPicBoxPitch.Image = pitchUp;
                orientPicBoxRoll.Image = rollLevel;
            }
            else if (accData.y < orientLowThresh)
            {
                orientationTextbox.Text = "Pitch down";
                orientPicBoxPitch.Image = pitchDown;
                orientPicBoxRoll.Image = rollLevel;
            }

            else if (accData.z > orientHighThresh)
            {
                orientationTextbox.Text = "Level";
                orientPicBoxPitch.Image = pitchLevel;
                orientPicBoxRoll.Image = rollLevel;
            }

            else if (accData.z < orientLowThresh)
            {
                orientationTextbox.Text = "Inverted";
                orientPicBoxPitch.Image = pitchInverted;
                orientPicBoxRoll.Image = rollInverted;
            }
            else
                orientationTextbox.Text = "";
        }

        // Check accelerations and display gestures
        private void GetGesture()
        {
            if (gestureState == "")
            {
                if (gestureCount == 0) // if no gestures start timer
                {
                    gestureTimer.Restart(); // restart if it stopped before
                }
                if (accData.x > gestureThresh)
                {
                    gestureState = "+X";
                }
                else if (accData.y > gestureThresh)
                {
                    gestureState = "+Y";
                }
                else if (accData.z > gestureThresh)
                {
                    gestureState = "+Z";
                }
                //else if (accData.z < gestureThreshNeg) // negative threshold
                //{
                //    gestureState = "-Z";
                //}
                else
                {
                    gestureState = "";
                }
                if (gestureState != "")
                {
                    StoreGesture();
                }
                DisplayGesture(); // show gesture 
            }
        }

        // Display gesture
        private void DisplayGesture()
        {
            currentAccelTextbox.Text = gestureState;
        }

        private void EasterEggButton_Click(object sender, EventArgs e)
        {
            if (gameLabel.Visible)
            {
                gameLabel.Visible = false;
                gameGestureTextbox.Visible = false;
                gameWonLabel.Visible = false;
                gameReset.Visible = false;
            }
            else
            {
                gameLabel.Visible = true;
                gameGestureTextbox.Visible = true;
                gameReset.Visible = true;
            }

        }

        private void StoreGesture()
        {
            gestureQueue.Enqueue(gestureState);
            gestureCount = gestureQueue.Count(); // get num gestures in queue 
            DisplayCombo(true);
        }

        private void GameReset_Click(object sender, EventArgs e)
        {
            gameState = false;
            gameWonLabel.Visible = false;
        }

        // Show combination of gesture and show gesture name
        private void DisplayCombo(bool playSound)
        {
            string[] gestures = gestureQueue.ToArray();
            string output = string.Join(" ", gestures);
            accelSequenceTextbox.Text = output;
            gameString = output; // for the game

            if (output == "+X")
            {
                gestureTextbox.Text = "Simple punch";
                if (playSound)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Safet\source\repos\Mech423Lab1\simplePunch.wav");
                    simpleSound.Play();
                }
            }
            else if (output == "+Z +X")
            {
                gestureTextbox.Text = "High punch";
                if (playSound)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Safet\source\repos\Mech423Lab1\highPunch.wav");
                    simpleSound.Play();
                }
            }
            else if (output == "+X +Y +Z")
            {
                gestureTextbox.Text = "Right hook";
                if (playSound)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Safet\source\repos\Mech423Lab1\rightHook.wav");
                    simpleSound.Play();
                }
            }
            else if (output == "+Y +Z")
            {
                gestureTextbox.Text = "Uppercut";
                if (playSound)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Safet\source\repos\Mech423Lab1\surprise.wav");
                    simpleSound.Play();
                }
            }
            else
            {
                gestureTextbox.Text = "";
            }
        }

        // Calculate and display yaw pitch roll
        private void GetYPR()
        {
            //double roll = (Math.Atan2(-1 * accData.y, accData.z) * 180) / Math.PI;
            //double pitch = (Math.Atan2(accData.x, Math.Sqrt(accData.y * accData.y + accData.z * accData.z)) * 180) / Math.PI;
            //YPR.roll = System.Convert.ToInt32(roll);
            //YPR.pitch = System.Convert.ToInt32(pitch);

            // YPR.roll = (accData.x - 125); // roll using x accel; 125 is zero, 3.6 multiplication factor
            // YPR.pitch = (accData.y - 125); // pitch using y accel

            YPR.pitch = Map(System.Convert.ToDouble(accData.y), 0, 255, -90, 90);
            YPR.pitch = Map(YPR.pitch, -20, 16, -90, 90);

            YPR.roll = Map(System.Convert.ToDouble(accData.x), 0, 255, -90, 90);
            YPR.roll = Map(YPR.roll, -19, 17, -90, 90);

            rollTextbox.Text = string.Format("{0:0.0}", YPR.roll);
            pitchTextbox.Text = string.Format("{0:0.0}", YPR.pitch);
        }

        // Map to rescale YPR from 0 to 255, to +/- 90 degrees
        public double Map(double value, double fromSource, double toSource, double fromTarget, double toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }

        private void DatalogCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // nothing for now
        }

        // CSV button deployment
        private void SaveToCSVButton_Click(object sender, EventArgs e)
        {
            if (!serialCom.IsOpen)
            {
                MessageBox.Show("Connect to device first!");
            }
            else
            {
                MessageBox.Show("Instructions: \n\n1) Enter a filename\n" +
                    "2) Check the datalog checkbox\n" +
                    "3) Profit");

                SaveFileDialog dialogBox = new SaveFileDialog();
                dialogBox.InitialDirectory = @"C:\Users\Safet\source\repos\Mech423Lab1";
                dialogBox.Filter = "CSV Files (*.csv)|*.csv";
                dialogBox.DefaultExt = "csv";
                dialogBox.ShowDialog();

                fileName = dialogBox.FileName; // save to global variable
            }
        }

        // Write to CSV
        public static void addRecord(int xAcc, int yAcc, int zAcc, string filepath)
        {
            List<string> records = new List<string>() {xAcc.ToString(), yAcc.ToString(), zAcc.ToString(), ""};

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
            {
                using (var csv = new CsvHelper.CsvWriter(file))
                {
                    csv.WriteField(records);
                    csv.NextRecord(); // prepares new data to write (carriage return in CSV)
                }
            }   
        }

        // Hidden game
        public void EasterEggGame()
        {
            if (!gameState)
            {
                Random rnd = new Random(); // randomize order of strings to win
                List<string> gestureOptions = new List<string> { "+Z +Z +Z", "+Y +X +Y", "+X +X +Z" };
                gameGestureTextbox.Text = gestureOptions[rnd.Next(0, 3)];
                gameState = true; // so that this loop only happens once
                gameWon = false;
            }

            // Winning condition; need gameWon condition else empty gameString will match
            if ((gameString == gameGestureTextbox.Text) && (gameWon == false))
            {
                gameWonLabel.Visible = true;
                gameWon = true;
                gameGestureTextbox.Text = "";
            }
        }
    }
}
