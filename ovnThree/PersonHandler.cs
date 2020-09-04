using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ovnThree
{
    internal class PersonHandler
    {
        //deklarera lista Personal
        private List<Person> persons;

        //konstruktorn för PersonalHandler
        public PersonHandler()
        {
            //instansierar lista persons
            persons = new List<Person>();

        }

        public Person CreatePerson(string fname, string lname, int age, double height, double weight)
        {
            Person p = new Person(fname, lname, age, height, weight);
            //sätter personens ålder till 100
            SetAge(p, 100); 
            persons.Add(p); // lägger till person till listan persons
           
            return p;
        }

        public void SetAge(Person pers, int age)
        {
             pers.Age = age;
        }

        //Förlag på fler metoder
        public int GetAge(Person pers)
        {
            return pers.Age;
        }

        public void SetFirstName(Person pers, string fname)
        {
            pers.FirstName = fname;
        }
    }
}