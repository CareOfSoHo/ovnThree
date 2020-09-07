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
            //this.DiffAttibut = diffAttibut;

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
        public override string DoStuff()
        {
            MakeSound = "ihahahaha";
            return MakeSound;
        }

        public override string Stats()
        {
            //Här anropas superklassens metod, hämtar egenskaperna i string-format och konkatenerar med hästens color-egenskap.
            return $"{base.Stats()} Color: {this.Color}";
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
            return $"{this.PetName} is a {this.Breed}, and is {this.Age} years old, and weights {this.Weight} kg";
        }
        public override string DoStuff()
        {
            MakeSound = "woff woff";
            return MakeSound;
        }
        public override string Stats()
        {
            return $"{base.Stats()} {this.Breed} {this.MakeSound}";
        }

        public override void DoSound()
        {
            //ToDo: Implementera DoSound
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
        public override string DoStuff()
        {
            MakeSound = "dont touch my spikes!!";
            return MakeSound;
        }
        public override string Stats()
        {
            return $"{this.PetName} {this.Age} {this.Weight}  {this.NoOfSpikes} {this.MakeSound}";

        }

        public override void DoSound()
        {
            //ToDo: Implementera DoSound
        }
    }

    class Worm : Animal
    {
        string IsPoisonous = "Venomous";
        public Worm(string petName, int age, double weight) : base(petName, age, weight)
        {
        }
        public override string ToString()
        {
            return $"{this.PetName} is {this.Age} years old, and weights {this.Weight} kg, and is really {this.IsPoisonous}";
        }
        public override string DoStuff()
        {
            MakeSound = "Don´t feed me to the fishes";
            return MakeSound;
        }
        public override string Stats()
        {
            return $"{this.PetName}  {this.Age}  {this.Weight}  {this.IsPoisonous} {this.MakeSound}";

        }

        public override void DoSound()
        {
            //ToDo: Implementera DoSound
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
        public override string DoStuff()
        {
            MakeSound = "piiip piip";
            return MakeSound;

        }
        public override string Stats()
        {
            return $"{this.PetName}  {this.Age}  {this.Weight}  {this.Wingspan} {this.MakeSound}";

        }

        public override void DoSound()
        {
            //ToDo: Implementera DoSound
        }
    }

    public class Wolf : Animal
    {
        string IsDangarous = "Dangerous";
        public Wolf(string petName, int age, double weight) : base(petName, age, weight)
        {
           
        }
        public override string ToString()
        {
            return $"{this.PetName} is very {this.IsDangarous}. He is {this.Age} years old, and weights {this.Weight} kg";
        }
        public override string DoStuff()
        {
            MakeSound = "well, I´m not gonna howl";
            return MakeSound;
        }
        public override string Stats()
        {
            return $"{this.PetName} {this.IsDangarous} {this.Age}  {this.Weight} {this.MakeSound}";
        }

        public override void DoSound()
        {
            //ToDo: Implementera DoSound
        }
    }

    public class WolfMan : Wolf, IPerson
    {
        string IsHybrid = "Dangerous";
        public WolfMan(string petName, int age, double weight) : base(petName, age, weight)
        {
            Talk();
            Stats();
        }
        public override string ToString()
        {
            return $"{this.PetName} is a {this.GetType().Name} . He is {this.Age} years old, and weights {this.Weight} kg";
        }
        public string Talk()
        {
            MakeSound = "I am the notorious wolfman";
            return MakeSound;
        }
        public override string Stats()
        {
            return $"{this.PetName} {this.IsHybrid} {this.Age}  {this.Weight} {this.MakeSound}";
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
        public override string DoStuff()
        {
            MakeSound = "piiip piip feeed meee";
            return MakeSound;
        }
        public override string Stats()
        {
            return $"{this.PetName} {this.KinfdOfBird} {this.Age}  {this.Weight} {this.MakeSound}";
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
        public override string DoStuff()
        {
            MakeSound = "Pretty in pink";
            return MakeSound;
        }
        public override string Stats()
        {
            return $"{this.PetName} {this.KindOfBird} {this.Age}  {this.Weight} {this.MakeSound}";
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
        public override string DoStuff()
        {
            MakeSound = "I am a beautiful swan";
            return MakeSound;
        }
        public override string Stats()
        {
            return $"{this.PetName} {this.kindOfBird} {this.Age}  {this.Weight} {this.MakeSound}";
        }
    }
}