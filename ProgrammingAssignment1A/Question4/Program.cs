using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class ProgramQ4
    {
        public static void Main()
        {
            int i = -1; //declaring i as a negative integer index
            var personList = new List<Person>(); //instantiating list object for Person object
            string decide = "y";
            while (decide == "y")
            {
                i += 1;
                Console.WriteLine("Enter your first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("\nCreating new person record...");
                //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
                System.Threading.Thread.Sleep(1000);
                personList.Add(new Person(firstName, lastName));
                Console.WriteLine("\nEnter your year of birth: ");
                personList[i].YearOfBirth = int.Parse(Console.ReadLine());
                Console.WriteLine($"\n--- Person Record ---\nFull Name: {personList[i].GetFullName()}\nAge: {personList[i].GetAge()}");
                Console.WriteLine("\nWould you like to add another person? y for yes, n for no.");
                decide = Console.ReadLine();
                if (decide == "n")
                {
                    Console.WriteLine("Returning to Main Menu...");
                    return;
                }
                while(decide != "y")
                {
                    Console.WriteLine("Invalid input. Please enter y to continue program, enter n to return to Main Menu.");
                    decide = Console.ReadLine();
                    if(decide == "n")
                    {
                        Console.WriteLine("Returning to Main Menu...");
                        //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
                        System.Threading.Thread.Sleep(1000);
                        return;
                    }
                }
            }
        }
    }
}
