using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Pelican : Bird
    {
        public bool IsColorful { get; set; }
        public Pelican(string name, int age, int weight, int height, string description, int wingSpan, bool isColorful) : base(name, age, weight, height, description, wingSpan)
        {
            IsColorful = isColorful;
        }
    }
}
