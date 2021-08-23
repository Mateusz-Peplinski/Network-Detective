using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Network_Detective
{
    public partial class portScanForm : Form
    {

        public volatile bool threadFlag_Abort;
        public volatile bool threadFlag_Start = false;
        public Thread portScanner0;

        public portScanForm()
        {
            InitializeComponent();
            portScanStopButton.Enabled = false;
        }

        private void portScanStartButton_Click(object sender, EventArgs e)
        {
            portScanStartButton.Enabled = false;
            portScanStopButton.Enabled = true;

            threadFlag_Abort = false;
            String userportIPAddr = userPingIPAddrTextBox.Text;

            portScanner0 = new Thread(() => portScanner0_Thread_0(userportIPAddr));

            portScanner0.Start();
            threadFlag_Start = true;
            displayCommonPortScanResults.Text += $"Scanning Started...{Environment.NewLine}";
        }

        public void portScanner0_Thread_0(String portIPAddr)
        {
            int[] commonPortArr = {7, 20, 21, 22, 23, 25, 42, 43, 53, 80, 443, 110, 135};
            String[] commonPortNameArr = {"echo", "FTP", "FTP", "SSH", "Telnet", "SMPT", "Host Name", "WHOIS", "DNS", "HTTP", "HTTPS", "POP3", "Windows RPC" };

            pingClass pingObj = new pingClass();

            bool isOnline = pingObj.tryPing(portIPAddr);

            if (isOnline)
            {
                while (!threadFlag_Abort)
                {
                    for (int currentScanPort = 0; currentScanPort < commonPortArr.Length; currentScanPort++)
                    {
                        bool portOpen = commonPortScan(portIPAddr, commonPortArr[currentScanPort]);

                        if (portOpen == true)
                        {
                            displayCommonPortScanResults.Text += $"Port: {commonPortArr[currentScanPort]} - {commonPortNameArr[currentScanPort]} --> Open {Environment.NewLine}";
                        }
                    }
                    displayCommonPortScanResults.Text += "<---   Scan Complete   --->";
                    threadFlag_Abort = true;
                }
            }
            else
            {
                displayCommonPortScanResults.Text += "Unable to Connect to specified IPv4 Address";
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

        private void portScanStopButton_Click(object sender, EventArgs e)
        {
            threadFlag_Abort = true;

            portScanner0.Abort();
        }

        private void portScanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadFlag_Start == true)
            {
                portScanner0.Abort();
            }
            threadFlag_Abort = true;

            portScanStartButton.Enabled = true;
            portScanStopButton.Enabled = false;
        }
    }
}
