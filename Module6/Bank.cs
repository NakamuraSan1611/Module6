﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Bank
    {
        public static int getID()
        {
            Random rand = new Random();
            int id = rand.Next(999999);
            return id;
        }
        public static int getPass()
        {
            Random rand = new Random();
            int pass = rand.Next(9999);
            return pass;
        }
    }
}
