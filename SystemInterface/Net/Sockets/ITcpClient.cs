using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SystemInterface.Net.Sockets
{
    public interface ITcpClient
    {
        Task ConnectAsync (IPAddress address, int port);

        void Close();
    }
}
