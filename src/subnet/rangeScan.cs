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
using System.Net;

namespace Network_Detective.subnetClass
{
    public partial class rangeScan : Form
    {

        public volatile bool threadFlag_Abort;
        public volatile bool threadFlag_Start = false;
        public Thread advScanner0;

        public rangeScan()
        {
            InitializeComponent();
            stopAdvScan.Enabled = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            showSubnetOpt opt = new showSubnetOpt();
            opt.Show();
        }

        private void startAdvScan_Click(object sender, EventArgs e)
        {

            advScanMainTextBox.Clear();

            startAdvScan.Enabled = false;
            threadFlag_Abort = false;

            String startIPAddr = IPAddrRange0.Text;
            String endIPAddr = IPAddrRange1.Text;

            advScanner0 = new Thread(() => advScan_Thread(startIPAddr, endIPAddr));
            advScanner0.Start();
            threadFlag_Start = true;
            stopAdvScan.Enabled = true;
        }

        private void advScan_Thread(String startIPAddr, String endIPAddr)
        {
            pingClass pingClassObj = new pingClass();
            int counter = 1;
            String startIP = startIPAddr;
            String lastIP = endIPAddr;

            string[] byteIndx0 = startIP.Split('.');
            string[] byteIndx1 = lastIP.Split('.');

            int oct4IP1 = Int32.Parse(byteIndx0[3]);
            int oct4IP2 = Int32.Parse(byteIndx1[3]);
            while (!threadFlag_Abort)
            {   
                if(counter == 1)
                {
                    bool subNetPingStatus0 = pingClassObj.tryPing(startIPAddr);

                    if (subNetPingStatus0 == true)
                    {

                        writeStatusMessage($"{startIPAddr} - SUCCESS {Environment.NewLine}");

                    }
                    else
                    {
                        writeStatusMessage($"{startIPAddr} - FAILED {Environment.NewLine}");

                    }
                    counter++;
                }
                counter++;

                
                if(oct4IP1  == oct4IP2)
                {
                    writeStatusMessage($"{Environment.NewLine} ---  Scan Finished! --- {Environment.NewLine}");
                    threadFlag_Abort = true;
                    break;
                }
                oct4IP1++;
                String nextIPToScan = String.Format("{0}.{1}.{2}.{3}", byteIndx0[0] , byteIndx0[1], byteIndx0[2], oct4IP1.ToString());

                bool subNetPingStatus = pingClassObj.tryPing(nextIPToScan);

                if (subNetPingStatus == true)
                {

                    writeStatusMessage($"{nextIPToScan} - SUCCESS {Environment.NewLine}");

                }
                else
                {
                    writeStatusMessage($"{nextIPToScan} - FAILED {Environment.NewLine}");

                }
            }
        }

        private void stopAdvScan_Click(object sender, EventArgs e)
        {
            writeStatusMessage($"{Environment.NewLine} --- Aborting Scan! --- {Environment.NewLine}");
            threadFlag_Abort = true;
            advScanner0.Abort();
            startAdvScan.Enabled = true;
            stopAdvScan.Enabled = false;
        }
        public void writeStatusMessage(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(writeStatusMessage), new object[] { text });
                return;
            }
            advScanMainTextBox.Text += text;
        }

        private void advSubnetScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadFlag_Start == true)
            {
                advScanner0.Abort();
            }
            threadFlag_Abort = true;
        }
    }
}
