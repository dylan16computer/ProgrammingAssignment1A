using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static int personCounter = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Person person1 = new Person(firstName, lastName);
            Console.WriteLine("Enter your year of birth: ");
            person1.YearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Full Name: {person1.GetFullName()}\nAge: {person1.GetAge()}");
            Console.WriteLine("Would you like to add another person? y for yes, n for no.");
            string decide = Console.ReadLine();
            if(decide == "y")
            {
                Console.WriteLine("Enter your first name: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                lastName = Console.ReadLine();
                Person person2 = new Person(firstName, lastName);
                Console.WriteLine("Enter your year of birth: ");
                person2.YearOfBirth = int.Parse(Console.ReadLine());
                Console.WriteLine($"Full Name: {person2.GetFullName()}\nAge: {person2.GetAge()}");
            }
            else if(decide == "n")
            {
                //-- https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console --//
                Environment.Exit(0);
            }
            //var people = new List<Person>();
            //NewPerson();
            //Console.WriteLine("Would you like to add another person? y for yes, n for no.");
            //string decide = Console.ReadLine();

            //if(decide == "y")
            //{
            //    personCounter += 1;
            //    NewPerson();
            //}
            //else if(decide == "n")
            //{
            //    Console.WriteLine("Exiting program...");
            //    //-- https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console --//
            //    Environment.Exit(0);
            //}

            //void NewPerson()
            //{
            //    Console.WriteLine("Enter your first name: ");
            //    string firstName = Console.ReadLine();
            //    Console.WriteLine("Enter your last name: ");
            //    string lastName = Console.ReadLine();
            //    Person personCounter = new Person(firstName, lastName);
            //    people.Add(new Person(firstName, lastName));
            //    Console.WriteLine("Enter your year of birth: ");
            //    personCounter.YearOfBirth = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Full Name: {personCounter.GetFullName()}\nAge: {personCounter.GetAge()}");
            //}
        }
    }
}
