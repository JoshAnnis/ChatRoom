using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace TCPChactRoom
    {
        class Client
        {


            public void Connect()
            {
                TcpClient client = new TcpClient("127.0.0.1", 4800);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                String s = String.Empty;
                SendMessage();

            }




            private void SendMessage()
            {
                Console.WriteLine("Enter your massage");
                Console.ReadLine();







            
        }
    }
}

       


