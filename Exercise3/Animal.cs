using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
   public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Description { get; set; }

        public Animal(string name, int age, int weight, int height, string description)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Description = description;

        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {Height}, Description: {Description}";
          
        }
        
    }
}
