using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInterface.Net;

namespace SystemWrapper.Net
{
    public class DnsWrap : IDns
    {
        public string GetHostName()
        {
            return System.Net.Dns.GetHostName();
        }
    }
}
