using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Network_Detective
{
    class pingClass
    {
        public bool tryPing(String IPAddr)
        {
            bool pingStatus = false;
            Ping pingObj = null;

            try
            {
                pingObj = new Ping();
                PingReply reply = pingObj.Send(IPAddr);

                pingStatus = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                pingStatus = false;
            }
            finally
            {
                if (pingObj != null)
                {
                    pingObj.Dispose();
                }
            }

            return pingStatus;
        }

    }
}
