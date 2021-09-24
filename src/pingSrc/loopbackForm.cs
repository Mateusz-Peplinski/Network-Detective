using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Detective
{
    public partial class loopbackForm : Form
    {
        public loopbackForm()
        {
            InitializeComponent();
            loopbacktest();
        }

        private void loopbacktest()
        {
            pingClass pingObj = new pingClass();

            String IPAddrv4 = "127.0.0.1";
            bool statusv4 = pingObj.tryPing(IPAddrv4);

            if (statusv4 == true)
            {
                loopbackStatusTextbox.Text += $"IPv4: \"{IPAddrv4}\" - Success {Environment.NewLine}";
            }
            else
            {
                loopbackStatusTextbox.Text += $"IPv4: \"{IPAddrv4}\" - Failed {Environment.NewLine}";
            }
            String IPAddrv6 = "::1";
            bool statusv6 = pingObj.tryPing(IPAddrv6);

            if (statusv6 == true)
            {
                loopbackStatusTextbox.Text += $"IPv6: \"{IPAddrv6}\"            - Success {Environment.NewLine}";
            }
            else
            {
                loopbackStatusTextbox.Text += $"IPv6: \"{IPAddrv6}\"            - Failed {Environment.NewLine}";
            }
        }
    }
    
}
