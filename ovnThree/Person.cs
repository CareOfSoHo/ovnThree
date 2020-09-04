using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ovnThree
{
    internal class Person
    {
        private string fName;
        private string lName;
        private int age;
        private double height;
        private double weight;


        public Person(string fName, string lName, int age, double height, double weight)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }



        public string FirstName
        {
            get
            {
                return this.fName;
            }
            set
            {
                if (value.Count() < 3 || value.Count() > 10)
                {
                    throw new ArgumentException("Förnamnet måste innehålla minst två tecken, och max 10 tecken");
                }
                this.fName = value;

            }
        }
        public string LastName
        {
            get
            {
                return this.lName;
            }
            set
            {
                if (value.Count() < 4 || value.Count() > 15)
                {
                    throw new ArgumentException("Förnamnet måste innehålla minst tre tecken, och max 15 tecken");
                }
                this.lName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ålder för ej vara 0 eller lägre");
                }
                this.age = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if(value > 2100)
                {
                    throw new ArgumentException("oops");
                }
                this.height = value;
            }

        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public override string ToString()
        {
            return $"{this.fName} {this.lName} är {this.age} år gammal, är {this.height} cm lång och väger {this.weight}";
        }
    }
}
