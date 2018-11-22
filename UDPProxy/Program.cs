using System;

namespace UDPProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PORT = 10100;
            Proxy proxy = new Proxy(PORT);
            proxy.Start();
            Console.ReadKey();
        }
    }
}
