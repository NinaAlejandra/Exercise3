﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Wolfman : IPerson
    {
        public void Talk()
        {
            Console.WriteLine("Wolfman says: Hello!");
        }
    }
}
