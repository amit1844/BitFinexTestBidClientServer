

using System;
using Grpc.Core;
using Com.Example.Grpc.Chat;

namespace GreeterServer
{
    class Program
    {
        const string Host = "localhost";
        const int Port = 8080;

        public static void Main(string[] args)
        {
            // Build server
            var server = new Server
            {
                Services = { ChatService.BindService(new ChatServiceImpl()) },
                Ports = { new ServerPort(Host, Port, ServerCredentials.Insecure) }
            };

            // Start server
            server.Start();

            Console.WriteLine("ChatServer listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
