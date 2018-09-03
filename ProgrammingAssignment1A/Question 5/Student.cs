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
            StudentID = randint.Next(0000, 9999); //passing the random integer to the StudentID setter
            return StudentID; //returning StudentID back to main program
        }
        public Student(string firstName, string lastName, string campus) : base(firstName, lastName) //constructor inherits Person class, referred to as base
        {
            FirstName = firstName; //passing the values of firstName and lastName to the setters of the Person class
            LastName = lastName;
            Campus = campus; //passing the value of campus to the setter of the Student class
        }
    }
}