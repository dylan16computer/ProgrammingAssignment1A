﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine($"\nAdding new student record to {student1.Campus} campus...");
            Console.WriteLine($"{student1.}");
        }
    }
}