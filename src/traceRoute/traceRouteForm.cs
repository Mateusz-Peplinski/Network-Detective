using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace Network_Detective
{
    public partial class traceRouteForm : Form
    {
        private Thread trc_THREAD;
        private bool isThreadRunning = false;
        public traceRouteForm()
        {
            InitializeComponent();
        }
        // add thread soution
        private void startTraceButton_Click(object sender, EventArgs e)
        {
            String destination = traceInputTextBox.Text;
            resultTextBox.Clear();
            trc_THREAD = new Thread(() => startTraceRoute(destination));
            trc_THREAD.Start();
            isThreadRunning = true;
            //startTraceRoute(destination);
        }

        public void startTraceRoute(string destination)
        {
            while (isThreadRunning)
            {
                for (int i = 1; i < 20; i++)
                {
                    String ip = getPacketRoute(destination, i);

                    if (ip == null)
                    {
                        break;
                    }
                    if (checkBox1.Checked)
                    {
                        String hostName = getHostName(ip);
                        resultTextBox.Text += String.Format("[{0}] - {1} [ {2} ] {3}", i, ip, hostName, Environment.NewLine);
                    }
                    else
                    {
                        resultTextBox.Text += String.Format("[{0}] - {1} {2}", i, ip, Environment.NewLine);
                    }

                }
            }
            
        }
        private string getHostName(string ipAdress)
        {
            string hostName = string.Empty;
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(ipAdress);

                hostName = hostEntry.HostName;
            }
            catch (Exception ex)
            {

            }
            if (hostName == null)
            {
                return "Hostname not Found !";
            }
            return hostName;
        }
        private String getPacketRoute(string destination, int ttl)
        {
            const string Data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Ping pingObj = new Ping();
            PingOptions pingObjOptions = new PingOptions(ttl, true);

            int timeout = 10000;
            byte[] buffer = Encoding.ASCII.GetBytes(Data);

            PingReply reply = default(PingReply);

            reply = pingObj.Send(destination, timeout, buffer, pingObjOptions);

            List<IPAddress> result = new List<IPAddress>();

            if (reply.Status == IPStatus.Success || reply.Status == IPStatus.TtlExpired)
            {

                return reply.Address.ToString();
            }
            else
            {
                return null;
            }
        }

        private void stopTraceRoute_Click(object sender, EventArgs e)
        {
            isThreadRunning = false;
            trc_THREAD.Join();
        }

        private void traceRouteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isThreadRunning = false;
            if (isThreadRunning)
            {
                trc_THREAD.Join();
            }
            
        }
    }
}
