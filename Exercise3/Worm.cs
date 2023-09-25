using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Worm : Animal
    {
        public bool IsPoisonous{ get; set; }

        public Worm(string name, int age, int weight, int height, string description, bool isPoisonous) : base(name, age, weight, height, description)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm sound: No idea");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, IsPoisonous: {IsPoisonous}";
        }
    }
}
