using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Horse : Animal
    {
        public bool IsRaceHorse { get; set; }

        public Horse(string name, int age, int weight, int height, string description, bool isRaceHorse) : base(name, age, weight, height, description) 
        {
        IsRaceHorse = isRaceHorse;
        }

        public override void DoSound()
        {
            Console.WriteLine("Horse sound: Neigh!");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, IsRaceHorse: {IsRaceHorse}";
        }

    }
}