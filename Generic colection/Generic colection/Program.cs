using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic_colection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> person = new Dictionary<string, string>()
            {
                { "Kristijan", "078282538" },
                { "Gjorgi", "000120000" },
                {"Nikola","222222222" }
            };

            bool appRun = true;
            while (appRun == true)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Search number");
                Console.WriteLine("2. New number");
                Console.WriteLine("3. Phonebook list");
                Console.WriteLine("4. End");
                Console.WriteLine("-------------------");

                string input = Console.ReadLine();


                int menuInput = int.Parse(input);
               

                switch (menuInput)
                {
                    case 1:

                        Console.WriteLine("Enter a Name");
                        string inputName = Console.ReadLine();

                        if (person.ContainsKey(inputName) == true)
                        {
                            Console.WriteLine("The number you hawe searched is: ");
                            Console.WriteLine(person[inputName]);
                        }
                        else
                        {
                            Console.WriteLine($"Phonebook doesent contain number for {inputName}");
                        }
                        break;

                    case 2:

                        Console.WriteLine("Enter name: ");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter number: ");
                        string Number = Console.ReadLine();
                        person.Add(Name, Number);
                        Console.WriteLine($"The {Name} was entered in phone book with number {Number}");
                        break;

                    case 3:
                        Console.WriteLine("Phonebook List");
                        for (int i = 0; i < person.Count; i++)
                        {
                            Console.WriteLine("Name: {0}, Number: {1}",
                                                                    person.Keys.ElementAt(i),
                                                                   person[person.Keys.ElementAt(i)]);
                        }
                        break;
           
                    case 4:
                        appRun = false;
                        break;
                }
                 
            }

            



               
        }

    }
}
