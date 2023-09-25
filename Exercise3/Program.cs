namespace Exercise3
{

    internal class Program
        {
            static void Main(string[] args)
            {
            //Person person = new Person(32, "Nina" +
            //    "", "Rivera", 153, 69);
            //Console.WriteLine(person);

            PersonHandler handler = new PersonHandler();
            Person Nina = handler.CreatePerson(32, "Nina", "Rivera", 152, 69);
            handler.SetAge(Nina, 33);
            PersonHandler.ChangeName(Nina, "Smith");

            Person Jonathan = handler.CreatePerson(26, "Jonathan", "Berglund", 180, 100);
            handler.SetAge(Jonathan, 27);
            PersonHandler.ChangeName(Jonathan, "Smith");
            
            Person Andrea = handler.CreatePerson(41, "Andrea", "Calderon", 158, 75);
            handler.SetAge(Andrea, 43);
            PersonHandler.ChangeName(Andrea, "Smith");
            
            Person Sara = handler.CreatePerson(26, "Sara", "Rehnström", 175, 60);
            handler.SetAge(Sara, 27);
            PersonHandler.ChangeName(Sara, "Smith");

            Console.WriteLine(Sara);
            Console.WriteLine(Jonathan);
            Console.WriteLine(Andrea);


            List<Animal> Animals = new List<Animal>();
            Animals.Add(new Horse("Polle", 15, 500, 175, "Svart med brun man", false));
            Animals.Add(new Dog("Obi", 3, 14, 100, "Lockig ljus päls", true));
            Animals.Add(new Bird("Hedvig", 12, 1, 30, "Vit med gula fläckar", 45));

            foreach (Animal animal in Animals)
            {
                Console.WriteLine($"Typ: {animal.GetType().Name}, Name: {animal.Name}");
                animal.DoSound();

                if(animal is IPerson)
                {
                IPerson person = (IPerson)animal;
                    person.Talk();
                }

                Console.WriteLine(animal.Stats());

                if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    Console.WriteLine(dog.Stats());
                }
            }

            List<Dog> Dogs = new List<Dog>();

            //Fungerar inte eftersom Dogs-listan är specifierad till att endast ta emot objekt av typen Dog. 
            //Listan måste vara av typen List<Animal> för att alla klasser som ärver från Animal ska kunna lagras tillsammans. 


        }
    }
     

    }
