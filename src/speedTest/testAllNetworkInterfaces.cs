using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Detective
{
    public partial class testAllNetworkInterfaces : Form
    {
        public testAllNetworkInterfaces()
        {
            InitializeComponent();
            onLoadDisplayNetworkInterfacesSpeed();
        }


        public void onLoadDisplayNetworkInterfacesSpeed()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                IPv4InterfaceStatistics stats = adapter.GetIPv4Statistics();
                textBox1.Text += $"{Environment.NewLine}";
                textBox1.Text += (adapter.Description);
                textBox1.Text += $"{Environment.NewLine}";
                textBox1.Text += $"   Speed: {adapter.Speed} {Environment.NewLine}";
                textBox1.Text += $"   Output queue length: {stats.OutputQueueLength} {Environment.NewLine}";
            }
        }
    }
}
