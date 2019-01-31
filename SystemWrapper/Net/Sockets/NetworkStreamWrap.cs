using System;
using System.Net.Sockets;
using SystemInterface.Net.Sockets;

namespace SystemWrapper.Net.Sockets
{
    public class NetworkStreamWrap : INetworkStream
    {
        public NetworkStreamWrap(NetworkStream networkStream)
        {
            Instance = networkStream ?? throw new ArgumentNullException(nameof(networkStream));
        }

        #region Implementation of IWrapper<out NetworkStream>

        /// <inheritdoc />
        public NetworkStream Instance { get; }

        #endregion
    }
}
