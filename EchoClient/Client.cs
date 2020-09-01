using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace EchoClient
{
    class Client
    {
        public void Start()
        {
            TcpClient socket = new TcpClient("localhost", 7);
            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            sw.WriteLine("Tristan");
            sw.Flush();
            string line = sr.ReadLine();
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
