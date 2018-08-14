using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            var personList = new List<Person>();
            string decide = "y"; //should decide be a char or string?
            while (decide == "y")
            {
                NewPerson();
                Console.WriteLine("\nWould you like to add another person? y for yes, n for no.");
                decide = Console.ReadLine();
            }
            if (decide == "n")
            {
                Console.WriteLine("Exiting program...");
                //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
                System.Threading.Thread.Sleep(1000);
                //-- https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            void NewPerson()
            {
                i += 1;
                Console.WriteLine("Enter your first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();
                personList.Add(new Person(firstName, lastName));
                Console.WriteLine("Enter your year of birth: ");
                personList[i].YearOfBirth = int.Parse(Console.ReadLine());
                Console.WriteLine($"--- Person Record ---\nFull Name: {personList[i].GetFullName()}\nAge: {personList[i].GetAge()}");
            }
        }
    }
}
