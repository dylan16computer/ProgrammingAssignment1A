using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question4;

namespace Question5
{
    public class ProgramQ5
    {
        public static void Main()
        {
            Console.WriteLine("Enter name of new student below: ");
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter campus: ");
            string campus = Console.ReadLine();
            Student student1 = new Student(firstName, lastName, campus);
            Console.WriteLine("Creating new person record...");
            Console.WriteLine($"Adding new student record to {student1.Campus} campus...");
            Console.WriteLine($"{student1.FirstName} {student1.LastName} of {student1.Campus} campus has a Student ID of {student1.EnrollStudent()}");
        }
    }
}
