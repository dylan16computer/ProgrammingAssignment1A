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
            Console.WriteLine("\nCreating new person record...");
            //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"\nAdding new student record to {student1.Campus} campus...");
            //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"\n{student1.FirstName} {student1.LastName} of {student1.Campus} campus has a Student ID of {student1.EnrollStudent()}");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey();
            return;
        }
    }
}
