using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ovnThree
{
    class Program
    {
        

        static void Main(string[] args)
        {
            PersonHandler manager = new PersonHandler();
            //Skapar listorna
            List<Animal> animalsList = new List<Animal>();
            List<Dog> dogsList = new List<Dog>();
            List<UserError> userErrorList = new List<UserError>();

            //hårdkodade värden
            string fname = "Anna";
            string lname = "Anakonda";
            int age = 35;
            double height = 160;
            double weight = 57.9;

            //Skapar en person via CreatePerson
            var persPerson = manager.CreatePerson(fname, lname, age, height, weight);
            //skriver ut den skapade personen - har bara en person, därav ingen foreach loop
            Console.WriteLine(persPerson);

            //ErrorLista med error meddelanden
            var msgNo = new NumericInputError();
            userErrorList.Add(msgNo);
            var msgText = new TextInputError();
            userErrorList.Add(msgText);

            var msgOne = new InputErrorFirst();
            userErrorList.Add(msgOne);
            var msgTwo = new InputErrorSecond();
            userErrorList.Add(msgTwo);
            var msgThree = new InputErrorThird();
            userErrorList.Add(msgThree);

            //skriver ut vilka felmeddelanden som finns
            foreach (var err in userErrorList)
            {
                Console.WriteLine(err.UEMessage());
            }

            //LÄgger till hundar till den specifika hund listan
            var dog1 = new Dog("nya FINKEL", 5, 21.3);
            dogsList.Add(dog1);

            var dog2 = new Dog("nya LAGO", 2, 6.7);
            dogsList.Add(dog2);
            Console.WriteLine("\n\n\t*********  DOGS FROM THE DOGSLIST ***********");
            foreach (var puppy in dogsList)
            {
                Console.WriteLine(puppy.Stats());
                Console.WriteLine(puppy.DogsOnly());
            }
            Console.WriteLine("-------------");

            //Lägger till div till animalListan
            var beast = new Dog("FINKEL", 5, 21.3);
            animalsList.Add(beast);

            var beast1 = new Dog("LAGO", 2, 6.7);
            animalsList.Add(beast1);

            var beast2 = new Wolf("ASKER", 3, 26.3);
            animalsList.Add(beast2);

            var beast3 = new Bird("FLICKA", 0, 0.3);
            animalsList.Add(beast3);

            var beast4 = new Pelican("LYXXA", 1, 26.3);
            animalsList.Add(beast4);

            var beast5 = new WolfMan("DIVA", 55, 96.3);
            animalsList.Add(beast5);


            if (animalsList.Count <= 0)
            {
                Console.WriteLine("The Animals List is empty");
            }
            else
            {
                //to set the header for the groups
                int noOfDogs = 0;
                int noOfPersons = 0;
                int noAnimals = 0;
                foreach (var item in animalsList)
                {
                    //Kollar här vilken typ item är
                    switch (item)
                    {
                        //om IPerson (wolfman)
                        case IPerson:
                            {
                                noOfPersons++;
                                if (noOfPersons == 1)
                                {
                                    Console.WriteLine("\n\n\t*********  PERSONS ONLY ***********");
                                    Console.WriteLine(item.Stats());
                                }
                                else
                                {
                                    Console.WriteLine(item.Stats());
                                }
                                break;
                            }
                            //om hund
                        case Dog:
                            {
                                noOfDogs++;
                                if (noOfDogs == 1)
                                {
                                    Console.WriteLine("\n\n\t*********  DOGS ONLY FROM THE ANIMALSLIST ***********");
                                    Console.WriteLine(item.Stats());
                                }
                                else
                                {
                                    Console.WriteLine(item.Stats());
                                }

                                break;
                            }
                            //övriga i animalsListan
                        default:
                            {
                                noAnimals++;

                                if (noAnimals == 1)
                                {
                                    Console.WriteLine("\n\n\t*********  OTHER ANIMALS  ***********");
                                    Console.WriteLine(item.Stats());
                                }
                                else
                                {
                                    Console.WriteLine(item.Stats());
                                }

                                break;
                            }
                    }

                }

                //tömmer listorna
                animalsList.Clear();
                dogsList.Clear();
                userErrorList.Clear();
            }

        }

    }
}
