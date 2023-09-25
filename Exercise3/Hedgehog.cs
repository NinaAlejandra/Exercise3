using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public Hedgehog(string name, int age, int weight, int height, string description, int numberOfSpikes) : base(name, age, weight, height, description)
        {
           NumberOfSpikes = numberOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog sound: Squeak");
        }
        public override string Stats()
        {
            return $"{base.Stats()}, NumberOfSpikes: {NumberOfSpikes}";
        }
    }
}
