using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ovnThree
{
    public abstract class Animal
    {
        //deklaration av egenskaper
        public string PetName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public string MakeSound { get; set; }

        public Animal(string petName, int age, double weight)
        {
            //nya värden för alla djur läggs här
            this.PetName = petName;
            this.Age = age;
            this.Weight = weight;

            DoStuff();
            Stats();

        }
        public virtual string Stats()
        {
            //Här kan du returnera värdena på Animal-egenskaperna och sen anropa den från subklasserna e.g kolla på Horse-klassen.
            return $"{PetName} is {Age} years old, and weights {Weight} kg";
        }

        //3.2 Punkt 3: Skapa en abstrakt metod som heter DoSound()
        //Denna metod måste då implementeras av dess subklasser.
        public abstract void DoSound();

        public virtual string DoStuff()
        {
            return MakeSound;
        }
    }


    //underklass till Animal
    class Horse : Animal
    {
        string Color = "Black";
        public Horse(string petName, int age, double weight) : base(petName, age, weight)
        {
        }
        public override string ToString()
        {
            return $"{this.PetName} is {this.Age} years old, and weights {this.Weight} kg and is {this.Color}";
        }
       

        public override string Stats()
        {
            //Här anropas superklassens metod, hämtar egenskaperna i string-format och konkatenerar med hästens color-egenskap.
            return $"\n{base.Stats()} Color: {this.Color}";
        }

        public override void DoSound()
        {
            //Exempel på implementering
            Console.WriteLine("IHahahah");
        }
    }

    class Dog : Animal
    {
        string Breed = "Staffordshire BullTerrier";
        public Dog(string petName, int age, double weight) : base(petName, age, weight)
        {
            DogsOnly();
        }

        public string DogsOnly()
        {
            return $"I am a dog";
        }

        public override string ToString()
        {
            return $"{this.PetName} and is {this.Age} years old, and weights {this.Weight} kg";
        }
       
        public override string Stats()
        {
            return $"\n {base.Stats()} Breed: {this.Breed}";
        }

       
        public override void DoSound()
        {
            Console.WriteLine("woff woff");
        }
    }

    class Hedgehog : Animal
    {
        int NoOfSpikes = 1000000;
        public Hedgehog(string petName, int age, double weight) : base(petName, age, weight)
        {
        }
        public override string ToString()
        {
            return $"{this.PetName} is {this.Age} years old, and weights {this.Weight} kg, and has {this.NoOfSpikes} spikes";
        }
      
        public override void DoSound()
        {
            Console.WriteLine("dont touch my spikes!!");
        }
        public override string Stats()
        {
            return $"\n {base.Stats()} Number of spikes: {this.NoOfSpikes}";

        }

    }

    class Worm : Animal
    {
        string IsPoisonous = "Very Venomous";
        public Worm(string petName, int age, double weight) : base(petName, age, weight)
        {
        }
        public override string ToString()
        {
            return $"{this.PetName} is {this.Age} years old, and weights {this.Weight} kg, and is really {this.IsPoisonous}";
        }
       
        public override string Stats()
        {
            return $"\n{base.Stats()} IsPoisonous: {this.IsPoisonous}";

        }

        public override void DoSound()
        {
            Console.WriteLine("Don´t feed me to the fishes");
        }
    }

    class Bird : Animal
    {
        //nya attribut för alla fåglar läggs i denna klass
        double Wingspan = 120.3;
        public Bird(string petName, int age, double weight) : base(petName, age, weight)
        {
        }
        public override string ToString()
        {
            return $"{this.PetName} is {this.Age} years old, and weights {this.Weight} kg and has a wingspan of {this.Wingspan}cm";
        }
       
        public override string Stats()
        {
            return $"\n{base.Stats()} Wingspan: {this.Wingspan}cm ";

        }

        public override void DoSound()
        {
            Console.WriteLine("piiip piip");
        }
    }

    public class Wolf : Animal
    {
        string IsDangarous = "Dangerous as a puppy";
        public Wolf(string petName, int age, double weight) : base(petName, age, weight)
        {
           
        }
        public override string ToString()
        {
            return $"{this.PetName} is very {this.IsDangarous}. He is {this.Age} years old, and weights {this.Weight} kg";
        }
     
        public override string Stats()
        {
            return $"\n{base.Stats()} IsDangarous: {this.IsDangarous}";
        }

        public override void DoSound()
        {
            Console.WriteLine("well, I´m not gonna howl");
        }
    }

    public class WolfMan : Wolf, IPerson
    {
        string IsHybrid = "It´s a hyrid";
        public WolfMan(string petName, int age, double weight) : base(petName, age, weight)
        {
            Talk();
            Stats();
        }
        public override string ToString()
        {
            return $"\n{this.PetName} is a {this.GetType().Name}. \nHe is {this.Age} years old, and weights {this.Weight} kg";
        }
        public void Talk()
        {
            Console.WriteLine("I am the notorious wolfman");
        }
       
        public override string Stats()
        {
            return $"\nFROM BASE:{base.Stats()} \nFROM SUB: \nIsHybrid: {this.IsHybrid}";
        }


    }
    class Pelican : Bird
    {
        string KinfdOfBird = "Pelican";
        public Pelican(string petName, int age, double weight) : base(petName, age, weight)
        {
        }
        public override string ToString()
        {
            return $"{this.PetName} is {this.Age} years old, and weights {this.Weight} kg";
        }
        
        public override void DoSound()
        {
            Console.WriteLine("piiip piip feeed meee");
        }
        public override string Stats()
        {
            return $"\n{base.Stats()} {this.KinfdOfBird}";
        }
    }
    class Flamingo : Bird
    {
        string KindOfBird = "Flamingo";
        public Flamingo(string petName, int age, double weight) : base(petName, age, weight)
        {
        }
        public override string ToString()
        {
            return $"{this.PetName} is {this.Age} years old, and weights {this.Weight} kg";
        }
        public override void DoSound()
        {
            Console.WriteLine("Pretty in pink");
        }
        public override string Stats()
        {
            return $"\n{base.Stats()} {this.KindOfBird}";
        }
    }
    class Swan : Bird
    {
        string kindOfBird = "SwNA";
        public Swan(string petName, int age, double weight) : base(petName, age, weight)
        {
        }
        public override string ToString()
        {
            return $"{this.PetName} is {this.Age} years old, and weights {this.Weight} kg";
        }
        public override void DoSound()
        {
            Console.WriteLine("I am a beautiful swan");
        }
        
        public override string Stats()
        {
            return $"\n{base.Stats()} {this.kindOfBird}";
        }
    }
}