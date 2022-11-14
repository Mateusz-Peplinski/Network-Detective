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
using System.CodeDom;
using System.Threading;


namespace Network_Detective
{
    public partial class mainMenu : Form
    {
        private Color ALPHA_buttonColour = Color.FromArgb(20, 90, 90, 90);
        private Thread animationServerThread;
        private bool isThreadRunning;

        public mainMenu()
        {
            InitializeComponent();
            FORCE_ARGB();
            this.DoubleBuffered = true;
            animationServerThread = new Thread(Animation_THREAD);
            animationServerThread.Start();
            isThreadRunning = true;
           
        }

        // ANIMATION REGION BELOW
        #region

        private void FORCE_ARGB()
        {
            //NI_tools.BackColor = Color.FromArgb(20, 90, 90, 90);
            NI_tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 90, 90, 90);
            RH_tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 90, 90, 90);
            NH_Tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 90, 90, 90);
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
        #endregion

        // CLICK EVENT REGION BELOW
        #region
        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
                isThreadRunning = false;
                animationServerThread.Join();
        }

        private void NI_tools_Click(object sender, EventArgs e)
        {
            NetworkInformationMenu networkInformationMenu = new NetworkInformationMenu();
            networkInformationMenu.Show();
        }
        private void RH_tools_Click(object sender, EventArgs e)
        {
            RemoteHostInfomationMenu remoteHostInfomationMenu = new RemoteHostInfomationMenu();
            remoteHostInfomationMenu.Show();
        }
        private void NH_Tools_Click(object sender, EventArgs e)
        {
            networkAdapterInformationForm networkAdapterInformationForm = new networkAdapterInformationForm();
            networkAdapterInformationForm.Show();   
        }

        private void myName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/0xInvicta");
        }
        #endregion

        
    }
}
