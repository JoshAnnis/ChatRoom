﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ChatRoomServer
{
    class SProgram
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.start();

        }
    }
}