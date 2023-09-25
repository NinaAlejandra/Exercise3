using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Bird : Animal
    {
        public int WingSpan { get; set; }

        public Bird(string name, int age, int weight, int height, string description, int wingSpan) : base(name, age, weight, height, description)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird sound: Shirp");
        }

        public override string Stats() 
        { 
        return $"{base.Stats()}, Wingspan: {WingSpan}";
        }
    }
}
// Om alla fåglar behöver ett nytt attribut så behöver det läggas här i denna klass så att alla fåglar har tillgång till den nya attributen eftersom de ärver den. 
// Men om alla djur behöver samma attribut så ska det läggas i Animal-klassen, på så sätt ärver alla djur attributen. 