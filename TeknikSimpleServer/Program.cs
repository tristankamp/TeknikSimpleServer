using System;

namespace TeknikSimpleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server simpleServer = new Server();
            simpleServer.start();

            Console.ReadLine();
        }
    }
}
