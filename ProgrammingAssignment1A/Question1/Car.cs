using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Car
    {
        string colour; //declaring private object properties
        string make;
        string gearbox;
        public string GetColour() //creating get and set methods for the instantiated object. string return type for returning a string, void type for returning nothing
        {
            return colour; //returning instance's property to the main program
        }
        public void SetColour(string col) //passing iser input colour property value from main program to the method
        {
            colour = col;
        }
        public string GetMake()
        {
            return make;
        }
        public void SetMake(string mk)
        {
            make = mk;
        }
        public string GetGearbox()
        {
            return gearbox;
        }
        public void SetGearbox(string gbox)
        {
            gearbox = gbox;
        }
    }
}
