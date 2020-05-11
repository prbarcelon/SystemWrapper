using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SystemInterface.Net.Sockets
{
    public interface ITcpClient : IDisposable, IWrapper<TcpClient>
    {
        /// <summary>Disposes this <see cref="T:SystemInterface.Net.Sockets.ITcpClient" /> instance and requests that the underlying TCP connection be closed.</summary>
        void Close();

        /// <summary>Connects the client to a remote TCP host using the specified IP address and port number as an asynchronous operation.</summary>
        /// <param name="address">The <see cref="T:System.Net.IPAddress" /> of the host to which you intend to connect. </param>
        /// <param name="port">The port number to which you intend to connect. </param>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address" /> parameter is <see langword="null" />. </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
        /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
        /// <exception cref="T:System.ObjectDisposedException">
        /// <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
        Task ConnectAsync(IPAddress address, int port);

        /// <summary>Connects the client to the specified TCP port on the specified host as an asynchronous operation.</summary>
        /// <param name="host">The DNS name of the remote host to which you intend to connect.</param>
        /// <param name="port">The port number of the remote host to which you intend to connect.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="host" /> parameter is <see langword="null" />.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> parameter is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
        /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket.</exception>
        /// <exception cref="T:System.ObjectDisposedException">
        /// <see cref="T:System.Net.Sockets.TcpClient" /> is closed.</exception>
        Task ConnectAsync(string host, int port);

        /// <summary>Returns the <see cref="T:System.Net.Sockets.NetworkStream" /> used to send and receive data.</summary>
        /// <returns>The underlying <see cref="T:System.Net.Sockets.NetworkStream" />.</returns>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.TcpClient" /> is not connected to a remote host. </exception>
        /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.TcpClient" /> has been closed. </exception>
        INetworkStream GetStream();
    }
}
