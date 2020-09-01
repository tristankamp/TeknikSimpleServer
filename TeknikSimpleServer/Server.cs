using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TeknikSimpleServer
{
    class Server
    {
        public void start()
        {
            
            TcpListener server = new TcpListener(IPAddress.Loopback,7);
            server.Start();
            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();

                DoClient(socket);
                socket.Close();
            }
            
        }

        public void DoClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            string str = sr.ReadLine();
            Console.WriteLine($"Server input er: {str}");

            string Upperstr = str.ToUpper();

            sw.WriteLine(Upperstr);
            sw.Flush();
        }
    }
}
