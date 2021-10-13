using System;
using WireMock.Server;

namespace ConsoleDotNet2
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = WireMockServer.Start();
            server.WithMapping();
            Console.WriteLine("Hello World!");
        }
    }
}
