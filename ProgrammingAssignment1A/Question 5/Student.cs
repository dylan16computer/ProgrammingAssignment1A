using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question4;

namespace Question5
{
    class Student: Person
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
        public Student(string firstName, string lastName, string campus) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Campus = campus;
        }
    }
}