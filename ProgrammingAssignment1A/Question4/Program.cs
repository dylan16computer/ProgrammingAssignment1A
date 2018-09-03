using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class ProgramQ4
    {
        public static void Main(string[] args)
        {
            string decide;
            int i = -1; //declaring i as a negative integer for use with the list index
            var personList = new List<Person>(); //instantiating list object to contain Person object
            do
            {
                i += 1; //adding +1 to "i" for it to index the list at index 0
                Console.WriteLine("Enter new person details below...\n\nEnter your first name: ");
                string firstName = Console.ReadLine(); //assigning user input value to variable
                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("\nCreating new person record...");
                personList.Add(new Person(firstName, lastName)); //adding a new Person to the personList list using list index, also passing variables to constructor
                Console.WriteLine("\nEnter your year of birth: ");
                personList[i].YearOfBirth = int.Parse(Console.ReadLine()); //passing year of birth user input to YearOfBirth property and referring to the same instance by using index (i)
                Console.WriteLine($"\n--- Person Record ---\nFull Name: {personList[i].GetFullName()}\nAge: {personList[i].GetAge()}"); //calling methods with list and its index number to return full name and age
                Console.WriteLine("\nWould you like to add another person? y for yes, n for no.");
                decide = Console.ReadLine();
            } while (decide == "y"); //while "decide" is equal to "y" run the above code
            if(decide =="n")
            {
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey();
            }
        }
    }
}
