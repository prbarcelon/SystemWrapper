using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using SystemInterface.Net.Sockets;

namespace SystemWrapper.Net.Sockets
{
    public class TcpClientWrap : ITcpClient
    {
        public TcpClientWrap(TcpClient tcpClient)
        {
            Instance = tcpClient ?? throw new ArgumentNullException(nameof(tcpClient));
        }

        #region Implementation of ITcpClient

        /// <inheritdoc />
        public void Close()
        {
            Instance.Close();
        }

        /// <inheritdoc />
        public async Task ConnectAsync(IPAddress address, int port)
        {
            await Instance.ConnectAsync(address, port);
        }

        /// <inheritdoc />
        public async Task ConnectAsync(string host, int port)
        {
            await Instance.ConnectAsync(host, port);
        }

        /// <inheritdoc />
        public INetworkStream GetStream()
        {
            return new NetworkStreamWrap(Instance.GetStream());
        }

        #endregion

        #region IDisposable

        /// <inheritdoc />
        public void Dispose()
        {
            ((IDisposable) Instance)?.Dispose();
        }

        #endregion

        #region Implementation of IWrapper<out TcpClient>

        /// <inheritdoc />
        public TcpClient Instance { get; }

        #endregion
    }
}
