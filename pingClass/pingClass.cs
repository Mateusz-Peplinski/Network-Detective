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
            //returns false unless set to true because of successful ping
            bool pingStatus = false;
            Ping pingObj = null;

            try
            {
                //try to ping with user IPAddr
                pingObj = new Ping();
                PingReply reply = pingObj.Send(IPAddr);
                //if successful set the ping status to true
                pingStatus = reply.Status == IPStatus.Success;
            }
            //if unsucessfull keep false
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
