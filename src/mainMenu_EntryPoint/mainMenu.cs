using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network_Detective.portScanningClass;
using Network_Detective.subnetClass;
using Network_Detective.src.processDumperClass;
using Network_Detective.src.speedTestSrc;
    
namespace Network_Detective
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void openPingForm_Click(object sender, EventArgs e)
        {
            pingForm pingForm = new pingForm();
            pingForm.Show();
        }

        private void openSubnetForm_Click(object sender, EventArgs e)
        {
            subnetScanForm subnetScanForm = new subnetScanForm();
            subnetScanForm.Show();
        }

        private void openPortScanForm_Click(object sender, EventArgs e)
        {
            portScanForm portScanForm = new portScanForm();
            portScanForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ADD About when the user presses the picture
        }

        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            portScanAdvanced portScanAdvancedFrom = new portScanAdvanced();
            portScanAdvancedFrom.Show();
        }


        private void openAdvancedNetworkScan_Click_1(object sender, EventArgs e)
        {
            rangeScan advSubnetForm = new rangeScan();
            advSubnetForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            traceRouteForm traceRouteForm = new traceRouteForm();
            traceRouteForm.Show();
        }

        private void dumpProcessForm_Click(object sender, EventArgs e)
        {
            processDumperForm processDumperForm = new processDumperForm();
            processDumperForm.Show();
        }

        private void openwifiSpeedtest_Click(object sender, EventArgs e)
        {
            wifiSpeedTestForm wifiSpeedTestForm = new wifiSpeedTestForm();
            wifiSpeedTestForm.Show();
        }
    }
}
