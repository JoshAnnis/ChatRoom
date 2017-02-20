using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ChatRoomServer
{
    class Server
    {
            TcpListener listener = null;
        public void start()
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 4800);
                listener.Start();
                Console.WriteLine("EchoServer started...");
                while (true)
                {
                    Console.WriteLine("Waiting for incoming client connections...");
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Accepted new client connection...", client);
                    StreamReader reader = new StreamReader(client.GetStream());
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    String s = String.Empty;
                    while (!(s = reader.ReadLine()).Equals("Exit"))
                    {
                        Console.WriteLine("From client -> " + s);
                        writer.WriteLine("From server -> " + s);
                        writer.Flush();
                    }
                
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
            public void Stop()
        {
            if (listener != null)
            {
                listener.Stop();
            }
        }
    }
}


