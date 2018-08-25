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
            string decide;
            int i = -1; //declaring i as a negative integer for use with the list index
            var personList = new List<Person>(); //instantiating list object for Person object
            do
            {
                i += 1;
                Console.WriteLine("Enter your first name: ");
                string firstName = Console.ReadLine(); //passing user input to the constructor
                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("\nCreating new person record...");
                personList.Add(new Person(firstName, lastName)); //adding a new Person to the personList list using list index
                Console.WriteLine("\nEnter your year of birth: ");
                personList[i].YearOfBirth = int.Parse(Console.ReadLine()); //passing year of birth user input to YearOfBirth property and referring to the instance by using index (i)
                Console.WriteLine($"\n--- Person Record ---\nFull Name: {personList[i].GetFullName()}\nAge: {personList[i].GetAge()}"); //calling methods with list and index to return full name and age
                Console.WriteLine("\nWould you like to add another person? y for yes, n for no.");
                decide = Console.ReadLine();
            } while (decide == "y");
        }
    }
}
