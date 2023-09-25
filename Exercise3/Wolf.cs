using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Wolf : Animal
    {
        public bool IsHuge { get; set; }

        public Wolf(string name, int age, int weight, int height, string description, bool isHuge) : base(name, age, weight, height, description)
        {
            IsHuge = isHuge;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf sound: Howl");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, IsHuge: {IsHuge}";
        }
    }
}
