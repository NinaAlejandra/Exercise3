namespace Exercise3
{
   public class Person
    {

        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FirstName = fName;
            LastName = lName;
            Height = height;
            Weight = weight;
        }


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Ålder måste vara större än 0");
                }

            }
        }

        public string FirstName
        {
            get { return fName; }
            set
            {
                try
                {
                    if (value.Length > 2 && value.Length < 10  && !string.IsNullOrEmpty(value))
                    {
                        fName = value;
                    }

                    else
                    {
                        throw new ArgumentException("Ange ett förnamn större än två bokstäver och mindre än tio.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                }
        }

            public string LastName
        {
            get { return lName; }
            set
            {
                try
                {
                    if (value.Length > 3 && value.Length < 15 && !string.IsNullOrEmpty(value))
                    {
                        lName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Ange ett efternamn större än tre bokstäver och mindre än femton");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }

        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override string ToString()
        {
            return $"Age: {Age}, First Name: {FirstName}, Last Name: {LastName}, Height: {Height}, Weight: {Weight}";
        }


    }

}
