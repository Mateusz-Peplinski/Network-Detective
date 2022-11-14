using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//https://docs.microsoft.com/en-us/dotnet/api/system.net.networkinformation.networkinterface?view=net-5.0


/// <summary>
///  KEY NOTE:               Fix index error if computer does not have IPv6 Addresses
/// </summary>

namespace Network_Detective
{
    public partial class networkAdapterInformationForm : Form
    {
        public networkAdapterInformationForm()
        {
            InitializeComponent();
            onLoad();
        }

        private void onLoad()
        {
            var ifcs = NetworkInterface.GetAllNetworkInterfaces();

            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String mainTitle = $"### Interface information for {computerProperties.HostName}.{computerProperties.DomainName} ###";
            titleText.Text = mainTitle;
            if (nics == null || nics.Length < 1)
            {
                mainListBox.Items.Add("  No network interfaces found.");
                return;
            }
            numOfAdapt.Text = $"Network Detective has found {nics.Length} Network Interfaces on {computerProperties.HostName}";
            foreach (NetworkInterface adapter in nics)
            {
                
                IPInterfaceProperties properties = adapter.GetIPProperties();
                
                mainListBox.Items.Add(adapter.Description);
                mainListBox.Items.Add(String.Empty.PadLeft(adapter.Description.Length, '='));
                mainListBox.Items.Add($"  Interface type .......................... : {adapter.NetworkInterfaceType}");
                mainListBox.Items.Add($"  Speed  .................................... :{adapter.Speed} bits per second");
                //mainListBox.Items.Add($"{adapter.GetIPProperties()}");
                mainListBox.ForeColor = Color.Green;
                mainListBox.Items.Add($"  IP .........................................:{adapter.GetIPProperties().UnicastAddresses[1].Address.ToString()}");
                mainListBox.Items.Add($"  IP .........................................:{adapter.GetIPProperties().UnicastAddresses[0].Address.ToString()}");
                mainListBox.ForeColor = Color.White;
                mainListBox.Items.Add($"  Physical Address ........................ : {adapter.GetPhysicalAddress().ToString()}");
                mainListBox.Items.Add($"  Operational status ...................... : {adapter.OperationalStatus}");
                string versions = "";


                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    versions = "IPv4";
                }
                if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                {
                    if (versions.Length > 0)
                    {
                        versions += " ";
                    }
                    versions += "IPv6";
                }
                mainListBox.Items.Add($"  IP version .............................. : {versions}");

                // The following information is not useful for loopback adapters.
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                {
                    continue;
                }
                mainListBox.Items.Add($"  DNS suffix .............................. : {properties.DnsSuffix}");

                string label;
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    IPv4InterfaceProperties ipv4 = properties.GetIPv4Properties();
                    mainListBox.Items.Add($"  MTU...................................... : {ipv4.Mtu}");
                    if (ipv4.UsesWins)
                    {

                        IPAddressCollection winsServers = properties.WinsServersAddresses;
                        if (winsServers.Count > 0)
                        {
                            label = "  WINS Servers ............................ :";

                        }
                    }
                }

                mainListBox.Items.Add($"  DNS enabled ............................. : {properties.IsDnsEnabled}");
                mainListBox.Items.Add($"  Dynamically configured DNS .............. : {properties.IsDynamicDnsEnabled}");
                mainListBox.Items.Add($"  Receive Only ............................ : {adapter.IsReceiveOnly}");
                mainListBox.Items.Add($"  Multicast ............................... : {adapter.SupportsMulticast}");
                //ShowInterfaceStatistics(adapter);

                mainListBox.Items.Add("");
            }
            


        }
    }
}
