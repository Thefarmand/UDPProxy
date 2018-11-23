using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace UDPProxy
{
    public class Proxy
    {

        private readonly int PORT;
        private const string uri = "http://localhost:64095/api/Sensor";

        public Proxy(int port)
        {
            PORT = port;
        }

        public void Start()
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            using (UdpClient receiverSock = new UdpClient(PORT))
            {
                while (true)
                {
                    Handler(receiverSock, remoteEP);
                }
            }
        }

        private void Handler(UdpClient receiverSock, IPEndPoint remoteEP)
        {
            byte[] data = receiverSock.Receive(ref remoteEP);
            String inStr = Encoding.ASCII.GetString(data);

            Console.WriteLine("modtaget " + inStr);
            Console.WriteLine(HttpClientSender(inStr));
        }

        private bool HttpClientSender(string data)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var response = client.PostAsync(uri, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
