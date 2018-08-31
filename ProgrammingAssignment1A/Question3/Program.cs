using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class ProgramQ3
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car(); //creating new instance of Car object
            Console.WriteLine("Enter your car colour: ");
            car1.Colour = Console.ReadLine(); //passing user input to the Colour getter and setter for car1 instance
            Console.WriteLine("Enter your car make: ");
            car1.Make = Console.ReadLine();
            Console.WriteLine("Enter your gearbox type: ");
            car1.Gearbox = Console.ReadLine();
            //below code is caling the getter to return the value of each property and print to the console
            Console.WriteLine($"\nYour car colour is a {car1.Colour} {car1.Make} with a {car1.Gearbox} transmission");
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey(); //waits for key press
        }
    }
}
