using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Swan : Bird
    {
        public bool IsAggressive { get; set; }
        public Swan(string name, int age, int weight, int height, string description, int wingSpan, bool isAggressive) : base(name, age, weight, height, description, wingSpan)
        {
            IsAggressive=isAggressive;
        }
    }
}
