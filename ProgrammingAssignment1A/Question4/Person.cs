using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class Person
    {
        public string FirstName { get; set; } //auto-implemented properties
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}"; //returning user's first and last name
        }
        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth; //returning user's age
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName; //setting first name private property to firstName user input value via auto-implemented properties
            LastName = lastName; //setting last name private property to lastName user input value via auto-implemented properties
        }
    }
}
