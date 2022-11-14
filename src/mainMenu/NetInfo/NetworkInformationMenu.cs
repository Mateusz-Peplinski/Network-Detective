using Network_Detective.src.speedTestSrc;
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
    public partial class NetworkInformationMenu : Form
    {
        private Thread animationServerThread;
        private bool isThreadRunning;
        public NetworkInformationMenu()
        {
            InitializeComponent();
            FORCE_ARGB();
            this.DoubleBuffered = true;
            animationServerThread = new Thread(Animation_THREAD);
            animationServerThread.Start();
            isThreadRunning = true; 
        }
        private void FORCE_ARGB()
        {
            
            subnetScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 90, 90, 90);
            speedTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 90, 90, 90);
            ping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 90, 90, 90);
        }
        private void subnetScan_Click(object sender, EventArgs e)
        {
            subnetScanForm subnetScanForm = new subnetScanForm();
            subnetScanForm.Show();
        }

        private void speedTest_Click(object sender, EventArgs e)
        {
            wifiSpeedTestForm wifiSpeedTestForm = new wifiSpeedTestForm();
            wifiSpeedTestForm.Show();   
        }

        private void ping_Click(object sender, EventArgs e)
        {
            pingForm ping = new pingForm();
            ping.Show();
        }

        private void subnetScan_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
        }

        private void subnetScan_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
        }

        private void speedTest_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
        }

        private void speedTest_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void ping_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void ping_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }
        public void Animation_THREAD()
        {
            Random randGENERATOR = new Random();
            while (isThreadRunning)
            {
                int randomNum = randGENERATOR.Next(0, 11);
                switch (randomNum)
                {
                    case 0:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame1;
                        Thread.Sleep(100);
                        break;
                    case 1:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame2;
                        Thread.Sleep(100);
                        break;
                    case 2:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame3;
                        Thread.Sleep(100);
                        break;
                    case 3:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame4;
                        Thread.Sleep(100);
                        break;
                    case 4:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame5;
                        Thread.Sleep(100);
                        break;
                    case 5:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame6;
                        Thread.Sleep(100);
                        break;
                    case 6:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame7;
                        Thread.Sleep(100);
                        break;
                    case 7:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame8;
                        Thread.Sleep(100);
                        break;
                    case 8:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame9;
                        Thread.Sleep(100);
                        break;
                    case 9:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame10;
                        Thread.Sleep(100);
                        break;
                    case 10:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame1;
                        Thread.Sleep(100);
                        break;
                    case 11:
                        server1.Image = global::Network_Detective.Properties.Resources.serverFrame5;
                        Thread.Sleep(100);
                        break;


                    default:
                        break;
                }
            }
        }

        private void NetworkInformationMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            isThreadRunning = false;
            animationServerThread.Abort(); //Fix to join with a flag to kill THREAD loop
        }
    }
}
