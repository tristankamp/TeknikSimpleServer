using System;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client TheOneClient = new Client();
            TheOneClient.Start();
        }
    }
}
