using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Detective
{

    /// <summary>
    /// NOTE: CHNAGE ABORT FLAG to make logical sense
    /// </summary>
    public partial class subnetScanForm : Form
    {
        public volatile bool threadFlag_Abort;
        public volatile bool threadFlag_Start = false;
        public Thread NetScanner0;
        public Thread NetScanner1;
        public Thread NetScanner2;

        public subnetScanForm()
        {
            InitializeComponent();
            AbortNetScannerThread.Enabled = false;
            showIPAddrOnScreen();

        }

        public void showIPAddrOnScreen()
        {
            networkScanClass networkScanClassObj = new networkScanClass();
            showIPAddr.Text += networkScanClassObj.getUserIPAddr();
        }

        public void startnetworkScan_Click(object sender, EventArgs e)
        {
            startnetworkScan.Enabled = false;
            AbortNetScannerThread.Enabled = true;

            threadFlag_Abort = false;
            String userNetIPAddr = userNetworkIPAddr.Text;

            networkScanClass networkScanClassObj = new networkScanClass();

            NetScanner0 = new Thread(() => subNetScanner_Thread_0(userNetIPAddr));
            NetScanner1 = new Thread(() => subNetScanner_Thread_1(userNetIPAddr));
            NetScanner2 = new Thread(() => subNetScanner_Thread_2(userNetIPAddr));
            NetScanner0.Start();
            NetScanner1.Start();
            NetScanner2.Start();
            threadFlag_Start = true;
           
        }
        public void subNetScanner_Thread_0(String userNetIPAddr)
        {
            pingClass pingClassObj = new pingClass();
            while (!threadFlag_Abort)
            {
                for (int octet4 = 2; octet4 < 84; octet4++)
                {
                    String fullIPAddr = $"{userNetIPAddr}.{octet4}";

                    bool subNetPingStatus = pingClassObj.tryPing(fullIPAddr);

                    if (subNetPingStatus == true)
                    {
                        showResultsBox0.Text += $"{fullIPAddr} - SUCCESS {Environment.NewLine}";
                    }
                    else
                    {
                        showResultsBox0.Text += $"{fullIPAddr} - FAILED {Environment.NewLine}";

                    }
                }
            }
            
            showResultsBox0.Text += "----- Scan Complete ----";
        }
        public void subNetScanner_Thread_1(String userNetIPAddr)
        {
            pingClass pingClassObj = new pingClass();
            while (!threadFlag_Abort)
            {
                for (int octet4 = 85; octet4 < 168; octet4++)
                {
                    String fullIPAddr = $"{userNetIPAddr}.{octet4}";

                    bool subNetPingStatus = pingClassObj.tryPing(fullIPAddr);

                    if (subNetPingStatus == true)
                    {

                        showResultsBox1.Text += $"{fullIPAddr} - SUCCESS {Environment.NewLine}";

                    }
                    else
                    {
                        showResultsBox1.Text += $"{fullIPAddr} - FAILED {Environment.NewLine}";

                    }
                }
            }
            
            showResultsBox1.Text += "----- Scan Complete ----";
        }
        public void subNetScanner_Thread_2(String userNetIPAddr)
        {
            pingClass pingClassObj = new pingClass();
            while (!threadFlag_Abort)
            {
                for (int octet4 = 169; octet4 < 255; octet4++)
                {
                    String fullIPAddr = $"{userNetIPAddr}.{octet4}";

                    bool subNetPingStatus = pingClassObj.tryPing(fullIPAddr);

                    if (subNetPingStatus == true)
                    {

                        showResultsBox2.Text += $"{fullIPAddr} - SUCCESS {Environment.NewLine}";

                    }
                    else
                    {
                        showResultsBox2.Text += $"{fullIPAddr} - FAILED {Environment.NewLine}";

                    }
                }
            }
            
            showResultsBox2.Text += "----- Scan Complete ----";
        }

        public void AbortNetScannerThread_Click(object sender, EventArgs e)
        {
            threadFlag_Abort =  true;

            NetScanner0.Abort();

            NetScanner1.Abort();

            NetScanner2.Abort();

            startnetworkScan.Enabled = true;
            AbortNetScannerThread.Enabled = false;

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            subnetScanHelpForm subnetScanHelpForm = new subnetScanHelpForm();
            subnetScanHelpForm.Show();
        }

        private void subnetScanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadFlag_Start == true)
            {
                NetScanner0.Abort();

                NetScanner1.Abort();

                NetScanner2.Abort();
            }
            threadFlag_Abort = true;

            
        }
    }
}
