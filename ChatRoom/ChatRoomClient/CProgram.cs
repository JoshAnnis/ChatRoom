using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPChactRoom;

namespace ChatRoomClient
{
    class CProgram
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Connect();
        }
    }
}
