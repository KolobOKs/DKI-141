﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface gameInterface = new Interface();
            gameInterface.KeyHandler();
        }
    }
}

