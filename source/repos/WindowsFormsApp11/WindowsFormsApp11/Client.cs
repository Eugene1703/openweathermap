using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    internal class Client
    {
        private const int bufSize = 8 * 1024;
        private byte[] buffer = new byte[bufSize];
        private Socket clientSocket;

        public async Task Start(string serverAddress, int serverPort, string dataToSend)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverAddress), serverPort);
            byte[] messageBytes = Encoding.ASCII.GetBytes(dataToSend);
            await clientSocket.SendToAsync(new ArraySegment<byte>(messageBytes), SocketFlags.None, serverEndPoint);
            clientSocket.Close();
        }

    }
}
