using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class ProgramQ1
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car(); //creating a new instance of the Car object
            Console.WriteLine("Enter your car colour: "); //printing to the console
            car1.SetColour(Console.ReadLine()); //obtaining user input for properties
            Console.WriteLine("Enter your car make: ");
            car1.SetMake(Console.ReadLine());
            Console.WriteLine("Enter your gearbox type: ");
            car1.SetGearbox(Console.ReadLine());
            //the below code is calling get methods to print car1's properties
            Console.WriteLine($"\nYour car is a {car1.GetColour()} {car1.GetMake()} with a {car1.GetGearbox()} transmission");
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey(); //waits for key input
        }
    }
}
