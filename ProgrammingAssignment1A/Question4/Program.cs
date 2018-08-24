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
            while (decide == "y") //while decide string is y, loop the code
            {
                i += 1;
                Console.WriteLine("Enter your first name: ");
                string firstName = Console.ReadLine(); //passing user input to the constructor
                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("\nCreating new person record...");
                //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
                System.Threading.Thread.Sleep(1000);
                personList.Add(new Person(firstName, lastName)); //adding a new Person to the personList list using list index
                Console.WriteLine("\nEnter your year of birth: ");
                personList[i].YearOfBirth = int.Parse(Console.ReadLine()); //passing year of birth user input to YearOfBirth property and referring to the instance by using index (i)
                Console.WriteLine($"\n--- Person Record ---\nFull Name: {personList[i].GetFullName()}\nAge: {personList[i].GetAge()}"); //calling methods with list and index to return full name and age
                Console.WriteLine("\nWould you like to add another person? y for yes, n for no.");
                decide = Console.ReadLine();
                if (decide == "n") //run the following code if decide is equal to n
                {
                    Console.WriteLine("Returning to Main Menu...");
                    return;
                }
                while(decide != "y") //run the following code if decide is not equal to y
                {
                    Console.WriteLine("Invalid input. Please enter y to continue program, enter n to return to Main Menu.");
                    decide = Console.ReadLine();
                    if(decide == "n") //run the following code if decide is equal to n
                    {
                        Console.WriteLine("Returning to Main Menu...");
                        //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
                        System.Threading.Thread.Sleep(1000);
                        return; //return to main menu
                    }
                }
            }
        }
    }
}
