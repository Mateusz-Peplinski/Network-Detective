
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;


namespace Network_Detective.src.speedTestSrc
{
    public partial class wifiSpeedTestForm : Form
    {

        public wifiSpeedTestForm()
        {
            InitializeComponent();
        }

        private void startSpeedTestButton_Click(object sender, EventArgs e)
        {

            runSpeedTest();

        }

        private void runSpeedTest()
        {
            double[] speeds = new double[5];
            for (int i = 0; i < 5; i++)
            {
                int fileSize = 50000; //Size of File in KB.
                WebClient client = new WebClient();
                DateTime startTime = DateTime.Now;
                client.DownloadFile("https://sabnzbd.org/tests/internetspeed/50MB.bin", "50MB.bin");
                DateTime endTime = DateTime.Now;
                File.Delete("50MB.bin");
                speeds[i] = Math.Round((fileSize / (endTime - startTime).TotalSeconds));
                currentSpeedtextBox.Text += (speeds[i] = Math.Round((fileSize / (endTime - startTime).TotalSeconds))).ToString(); 
                currentSpeedtextBox.Text += Environment.NewLine;
            }
            currentSpeedtextBox.Text = string.Format("Download Speed: {0}KB/s", speeds.Average());
            File.Delete("50MB.bin");
        }

        private void testNetInter_Click(object sender, EventArgs e)
        {
            testAllNetworkInterfaces testAllNetworkInterfacesFrom = new testAllNetworkInterfaces();
            testAllNetworkInterfacesFrom.Show();
        }
    }
}
