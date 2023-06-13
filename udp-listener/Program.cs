using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        int port = 12345; 
        string ipAddress = "192.168.10.102"; 

        IPAddress localAddress = IPAddress.Parse(ipAddress);
        IPEndPoint localEndPoint = new IPEndPoint(localAddress, port);

        using (UdpClient client = new UdpClient(localEndPoint))
        {
            // Enable broadcasting
            client.EnableBroadcast = true;

            // Start listening for UDP broadcasts
            Console.WriteLine($"Listening for UDP broadcasts on {localEndPoint}...");

            while (true)
            {
                // Receive UDP packets
                IPEndPoint remoteEndpoint = null;
                byte[] receivedData = client.Receive(ref remoteEndpoint);

                // Convert the received data to a string
                string receivedMessage = Encoding.ASCII.GetString(receivedData);

                // Display the received message
                Console.WriteLine($"Received from {remoteEndpoint.Address}: {receivedMessage}");
            }
        }
    }
}
