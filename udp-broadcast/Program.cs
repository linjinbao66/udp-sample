using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        int port = 12345; // Specify the port number to send the UDP broadcast to
        string broadcastAddress = "192.168.10.102"; // Specify the broadcast IP address

        using (UdpClient client = new UdpClient())
        {
            client.EnableBroadcast = true;

            // Prepare the message to be sent
            string message = "Hello, broadcast!";
            byte[] sendData = Encoding.ASCII.GetBytes(message);

            // Send the UDP broadcast
            client.Send(sendData, sendData.Length, broadcastAddress, port);

            Console.WriteLine($"Sent UDP broadcast: {message}");
        }
    }
}
