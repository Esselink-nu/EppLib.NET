using System.Collections.Generic;

namespace EppLib.Entities
{
    public class NameServer
    {
        public string HostName { get; set; }

        public IList<HostAddress> HostAddresses { get; }

        public NameServer()
        {
            HostAddresses = new List<HostAddress>();
        }

        public NameServer(string hostname) : this()
        {
            HostName = hostname;
        }

        public NameServer(string hostname, HostAddress hostAddress) : this()
        {
            HostName = hostname;
            HostAddresses.Add(hostAddress);
        }
    }
}
