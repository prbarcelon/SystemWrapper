using System;

namespace SystemInterface.Net
{
    public interface IDns
    {
        //IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state);

        //IAsyncResult BeginGetHostByName(string hostName, AsyncCallback requestCallback, object stateObject);

        string GetHostName();
    }
}