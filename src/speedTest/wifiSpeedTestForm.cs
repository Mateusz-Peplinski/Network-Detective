
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
using System.Collections;


namespace Network_Detective.src.speedTestSrc
{
    public partial class wifiSpeedTestForm : Form
    {
        private Thread speedTestThread;
        private bool isThreadRuning = false;
        public wifiSpeedTestForm()
        {
            InitializeComponent();
        }

        public Dictionary<string,string> getSpeedInfo()
        {
            Dictionary<string, string> speedResult = null;
            
            Process runspeedTestProc = null;
            try
            {
                speedResult = new Dictionary<string, string>();
                runspeedTestProc = new Process();
                runspeedTestProc.StartInfo.UseShellExecute = false;
                runspeedTestProc.StartInfo.RedirectStandardOutput = true;
                runspeedTestProc.StartInfo.CreateNoWindow = true;
                runspeedTestProc.StartInfo.FileName = "speedtest.exe";
                runspeedTestProc.Start();
                string output = runspeedTestProc.StandardOutput.ReadToEnd();
                runspeedTestProc.WaitForExit();

                List<string> results = output.Split('\n').ToList();

                speedResult["Server"] = results[3].Split(':')[1].Trim().Replace("(id","");
                speedResult["ISP"] = results[4].Split(':')[1].Trim();
                speedResult["Latency"] = results[5].Split(':')[1].Trim().Replace("(jitter","");
                speedResult["Download"] = results[6].Replace("Download: ", "").Trim();   
                speedResult["Upload"] = results[8].Replace("Upload: ", "").Trim();  
                speedResult["PacketLoss"] = results[9].Split(':')[1].Trim().Replace("(data used","");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (runspeedTestProc != null)
                {
                    runspeedTestProc.Dispose();
                }
            }
            return speedResult; 
        }

        private void startSpeedTestButton_Click(object sender, EventArgs e)
        {
            currentSpeedtextBox.Text += "Starting Test..." + Environment.NewLine;
            //Dictionary results = speedTestThread = new Thread(getSpeedInfo);

             speedTestThread = new Thread(() => {
                 isThreadRuning = true;
                var results =  getSpeedInfo();
                 if (results != null)
                 {
                     currentSpeedtextBox.Text += "Server: " + results["Server"] + Environment.NewLine;
                     currentSpeedtextBox.Text += "ISP: " + results["ISP"] + Environment.NewLine;
                     currentSpeedtextBox.Text += "Latency: " + results["Latency"] + Environment.NewLine;
                     currentSpeedtextBox.Text += "Download: " + results["Download"] + Environment.NewLine;
                     currentSpeedtextBox.Text += "Upload: " + results["Upload"] + Environment.NewLine;
                     currentSpeedtextBox.Text += "PacketLoss: " + results["PacketLoss"] + Environment.NewLine;
                 }
             });
            speedTestThread.Start();
            speedTestThread.Join();

            
        }

        private void testNetInter_Click(object sender, EventArgs e)
        {
            testAllNetworkInterfaces testAllNetworkInterfacesFrom = new testAllNetworkInterfaces();
            testAllNetworkInterfacesFrom.Show();
        }

        private void wifiSpeedTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThreadRuning == true)
            {
                speedTestThread.Join();
            }
        }
    }
}
