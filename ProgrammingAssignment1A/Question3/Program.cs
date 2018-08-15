using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class ProgramQ3
    {
        public static void Main()
        {
            Car car1 = new Car();
            Console.WriteLine("Enter your car colour: ");
            car1.Colour = Console.ReadLine();
            Console.WriteLine("Enter your car make: ");
            car1.Make = Console.ReadLine();
            Console.WriteLine("Enter your gearbox type: ");
            car1.Gearbox = Console.ReadLine();
            Console.WriteLine($"Your car colour is a {car1.Colour} {car1.Make} with a {car1.Gearbox} transmission");
        }
    }
}
