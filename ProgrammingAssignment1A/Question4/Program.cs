using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static int i = -1;
        static void Main(string[] args)
        {
            var personList = new List<Person>();
            string decide;
            do
            {
                NewPerson();
                Console.WriteLine("Would you like to add another person? y for yes, n for no.");
                decide = Console.ReadLine();
            } while (decide == "y");
            if (decide == "n")
            {
                Console.WriteLine("Exiting program...");
                //-- https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console --//
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            void NewPerson()
            {
                //Console.WriteLine("Enter name of instance: ");
                //string intance = Console.ReadLine();
                Console.WriteLine("Enter your first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter your year of birth: ");
                int YearOfBirth = int.Parse(Console.ReadLine());
                personList.Add(new Person(firstName, lastName));
                //Console.WriteLine(personList.Count);
                i += 1;
                Console.WriteLine($"Full Name: {personList[i].GetFullName()}\n{personList[i].YearOfBirth}");
                //Console.WriteLine(DateTime.Now.Year);
            }
        }
    }
}
