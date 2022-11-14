using Network_Detective.portScanningClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Detective
{
    public partial class RemoteHostInfomationMenu : Form
    {
        private Thread animationTextThread;
        private bool isThreadRunning;

        public RemoteHostInfomationMenu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            FORCE_ARGB();       
            animationTextThread = new Thread(animatedTextBox_THREAD);
            animationTextThread.Start();
            isThreadRunning = true;
            
        }
        private void FORCE_ARGB()
        {
            //NI_tools.BackColor = Color.FromArgb(20, 90, 90, 90);
            portScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(20, 90, 90, 90);
            TraceRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(20, 90, 90, 90);
            TryPing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(20, 90, 90, 90);
        }

        private void portScan_Click(object sender, EventArgs e)
        {
            if (AdvCheckBox.Checked == true)
            {
                portScanAdvanced portScanAdvanced = new portScanAdvanced(); 
                portScanAdvanced.Show();
            }
            else
            {
                portScanForm portScanForm = new portScanForm();
                portScanForm.Show();
            }
        }
     
        private void TraceRoute_Click(object sender, EventArgs e)
        {
            traceRouteForm traceRouteForm = new traceRouteForm();
            traceRouteForm.Show();
        }

        private void TryPing_Click(object sender, EventArgs e)
        {
            pingForm ping = new pingForm();
            ping.Show();
        }

        private void TraceRoute_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }

        private void TraceRoute_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void TryPing_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
        }

        private void TryPing_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void portScan_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void portScan_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void GatherInteligence_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
        }

        private void GatherInteligence_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void animatedTextBox_THREAD()
        {

            string optString = "/root/ $: \necho \"PLEASE SELECT AN OPTION...\" \n$: NETWORK DETECTIVE";
            
            int size = optString.Length;
            while (isThreadRunning)
            {
                for (int i = 0; i < size; i++)
                {
                    if (isThreadRunning == false)
                    {
                        i = size;
                    }
                    else
                    {
                        animatedTextBox.Text += (optString[i]);
                        Thread.Sleep(300);
                    }
                    
                }
                animatedTextBox.Text = " ";
            }
            
        }

        private void RemoteHostInfomationMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            isThreadRunning = false;
            animationTextThread.Join();
        }
    }
}
