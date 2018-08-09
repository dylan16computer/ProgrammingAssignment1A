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
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            Person person1 = new Person(firstName, lastName);
            Console.WriteLine("Adding new person to record");
            Console.WriteLine("Enter your year of birth: ");
            int YearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Full Name: {person1.GetFullName(firstName, lastName)}\nYour age: {person1.GetAge(YearOfBirth)}");
        }
    }
}
