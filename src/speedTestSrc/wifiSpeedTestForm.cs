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
using System.Windows.Forms;


namespace Network_Detective.src.speedTestSrc
{
    public partial class wifiSpeedTestForm : Form
    {
        private volatile bool threadFlag_Abort;
        private volatile float seconds;

        public wifiSpeedTestForm()
        {
            InitializeComponent();
        }

        private void startSpeedTestButton_Click(object sender, EventArgs e)
        {
            threadFlag_Abort = false;

            Thread timer_THREAD0 = new Thread(timer_THREAD);
            currentSpeedtextBox.Clear();
            timer_THREAD0.Start();

            WebClient webClient = new WebClient();

            Uri URL = new Uri("http://ipv4.download.thinkbroadband.com:81/20MB.zip");
            while (!threadFlag_Abort)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("User-Agent: Other");
                    wc.DownloadFile(URL, "wifi_TEST_TEMP.zip");
                    threadFlag_Abort = true;
                    timer_THREAD0.Abort();
                }
            }

            String wifiFile = "wifi_TEST_TEMP.zip";
            long FileSize = wifiFile.Length;

            double speedInBytes = FileSize / seconds;

            double speedInMegaBits = (speedInBytes / 8) / 8 ;
            //currentSpeedtextBox.Text += string.Format("{0:0.#}Mbps", speedInMegaBits);
            currentSpeedtextBox.Text += string.Format("{0}", speedInMegaBits);


        }
        private void timer_THREAD()
        {
            Stopwatch downloadTimer = new Stopwatch();
            downloadTimer.Reset();
            downloadTimer.Start();
            while (seconds < 60)
            {
                seconds = (float)downloadTimer.Elapsed.TotalSeconds;
            }
            threadFlag_Abort = true;
            downloadTimer.Stop();

            seconds = (float)downloadTimer.Elapsed.TotalSeconds;
        }

        private void testNetInter_Click(object sender, EventArgs e)
        {
            testAllNetworkInterfaces testAllNetworkInterfacesFrom = new testAllNetworkInterfaces();
            testAllNetworkInterfacesFrom.Show();
        }
    }
}
