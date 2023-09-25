﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Flamingo : Bird
    {
        public bool IsPink {  get; set; }
        public Flamingo(string name, int age, int weight, int height, string description, int wingSpan, bool isPink) : base(name, age, weight, height, description, wingSpan)
        {
            IsPink=isPink;
        }
    }
}
