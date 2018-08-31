using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public class ProgramQ5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name of new student below: ");
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine(); //assigning user input value to variable
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter campus: ");
            string campus = Console.ReadLine();
            Student student1 = new Student(firstName, lastName, campus); //passing user input variables to Student constructor
            //below code is referring to getters and methods to print campus, student ID and full name
            Console.WriteLine($"\nCreating new person record...\n\nAdding new student record to {student1.Campus} campus...\n\n{student1.GetFullName()}" +
            $" of {student1.Campus} campus has a Student ID of {student1.EnrollStudent()}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(); //waiting for key press
        }
    }
}
