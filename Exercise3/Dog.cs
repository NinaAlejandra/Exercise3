using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Dog : Animal
    {
        public bool IsLapDog{ get; set; }

        public Dog(string name, int age, int weight, int height, string description, bool isLapDog) : base(name, age, weight, height, description)
        {
            IsLapDog = isLapDog;
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog sound: Woooff!");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, IsLapDog: {IsLapDog}";
        }
    }
}
