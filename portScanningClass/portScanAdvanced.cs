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
using System.Net.Sockets;

namespace Network_Detective.portScanningClass
{
    public partial class portScanAdvanced : Form
    {
        public volatile bool threadFlag_Abort;
        public volatile bool threadFlag_Start = false;
        public Thread portScannerAdv0;

        public portScanAdvanced()
        {
            InitializeComponent();
            showAboutText();
            stopAdvancedPortScan.Enabled = false;
        }

        public void showAboutText()
        {
            aboutTextBox.Text += @"Note:
This Scan may take some time as it will attempt to scan every port. 
- Default is ports 7 -> 1024. 
- Toggle Full Scan for 7 -> 65536";
        }

        private void startAdvancedPortScan_Click(object sender, EventArgs e)
        {
            startAdvancedPortScan.Enabled = false;
            stopAdvancedPortScan.Enabled = true;

            int numPortsToScan = 1024;

            if (fullScancheckBox.Checked)
            {
                numPortsToScan = 65536;
            }
            threadFlag_Abort = false;
            String userportIPAddr = userIPAddrPortAdv.Text;

            portScannerAdv0 = new Thread(() => portScannerAdv0_Thread_0(userportIPAddr, numPortsToScan));

            portScannerAdv0.Start();
            threadFlag_Start = true;
            showAdvPortScanResults.Text += $"Scanning Started...{Environment.NewLine}";
        }

        public void portScannerAdv0_Thread_0(String portIPAddr, int numPortsToScan)
        {

            pingClass pingObj = new pingClass();

            bool isOnline = pingObj.tryPing(portIPAddr);

            if (isOnline)
            {
                while (!threadFlag_Abort)
                {
                    for (int port = 0; port < numPortsToScan; port++)
                    {
                        bool portOpen = commonPortScan(portIPAddr, port);

                        if (portOpen == true)
                        {
                            showAdvPortScanResults.Text += $"Port: {port} --> Open {Environment.NewLine}";
                        }
                        else
                        {
                            showAdvPortScanResults.Text += $"Port: {port} --> Closed {Environment.NewLine}";
                        }
                    }
                    showAdvPortScanResults.Text += "<---   Scan Complete   --->";
                    threadFlag_Abort = true;
                }
            }
            else
            {
                showAdvPortScanResults.Text += "Unable to Connect to specified IPv4 Address";
                threadFlag_Abort = true;
            }

        }

        public bool commonPortScan(String portIPAddr, int portNum)
        {
            bool portStatus = false;
            try
            {
                using (var client = new TcpClient())
                {
                    var result = client.BeginConnect(portIPAddr, portNum, null, null);
                    client.EndConnect(result);
                    portStatus = true;
                }
            }
            catch
            {
                portStatus = false;
            }
            return portStatus;
        }

        private void stopAdvancedPortScan_Click(object sender, EventArgs e)
        {
            threadFlag_Abort = true;
            portScannerAdv0.Abort();
            startAdvancedPortScan.Enabled = true;
            stopAdvancedPortScan.Enabled = false;
        }

        private void portScanAdvanced_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadFlag_Start == true)
            {
                portScannerAdv0.Abort();
            }
            threadFlag_Abort = true;
        }
    }
}
