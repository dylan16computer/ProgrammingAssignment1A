using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question4; //referencing Question 4 to inherit the Person class

namespace Question5
{
    class Student: Person //inheriting the Person class
    {
        public string Campus { get; set; } //auto-implemented properties
        public int StudentID { get; set; }
        public int EnrollStudent() //method returns a random number between 0000 and 9999
        {
            Random randint = new Random();
            //-- https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp --//
            StudentID = randint.Next(0000, 9999);
            return StudentID;
        }
        public Student(string firstName, string lastName, string campus) : base(firstName, lastName) //constructor inherits Person class, referred to as base
        {
            FirstName = firstName; //passing the values of the variables to the setters.
            LastName = lastName;
            Campus = campus;
        }
    }
}