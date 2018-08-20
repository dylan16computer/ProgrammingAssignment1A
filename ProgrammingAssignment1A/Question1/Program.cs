using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class ProgramQ1
    {
        public static void Main()
        {
            Car car1 = new Car(); //instatiating a new instance
            Console.WriteLine("Enter your car colour: ");
            car1.SetColour(Console.ReadLine()); //obtaining user input for properties
            Console.WriteLine("Enter your car make: ");
            car1.SetMake(Console.ReadLine());
            Console.WriteLine("Enter your gearbox type: ");
            car1.SetGearbox(Console.ReadLine());
            Console.WriteLine($"Your car colour is a {car1.GetColour()} {car1.GetMake()} with a {car1.GetGearbox()} transmission"); //calling get methods to print instantiated instance's properties
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey(); //reading the next key input by user
            return; //returning to main menu
        }
    }
}
