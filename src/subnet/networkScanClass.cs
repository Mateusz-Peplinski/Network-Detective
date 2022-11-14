using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Network_Detective
{
    class networkScanClass
    {
        public string getUserIPAddr()
        {
            String ipAddr = "";
            int counter = 1;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddr += $"[{counter}] {ip.ToString()} {Environment.NewLine}";                   
                    counter++;
                }               
            }
            return ipAddr;
        }

    }
}
