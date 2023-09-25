using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson (int age, string fname, string lname, double height, double weight)
        {
            return new Person(age, fname, lname, height, weight);   
        }

        public static void ChangeName(Person pers, string newLastName)
        {
            if (newLastName.Length > 3 && newLastName.Length < 15 && !string.IsNullOrEmpty(newLastName))
                {
                pers.LastName = newLastName;
            }
            else
            {
                {
                        Console.WriteLine("Ange ett efternamn större än tre bokstäver och mindre än femton");
                }
            }
        }
    }
}
