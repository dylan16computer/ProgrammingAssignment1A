using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public int GetAge()
        {
            return 2018 - YearOfBirth;
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    class Student
    {
        public string Campus { get; set; }
        public int StudentID { get; set; }
        public int EnrollStudent()
        {
            Random randint = new Random();
            //-- https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp --//
            StudentID = randint.Next(0000, 9999);
            return StudentID;
        }
        public Student(string firstName, string lastName, string campus)
        {

        }
    }
}