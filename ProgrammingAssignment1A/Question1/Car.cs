using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Car
    {
        string colour;
        string make;
        string gearbox;
        public string GetColour()
        {
            return colour;
        }
        public void SetColour(string value)
        {
            colour = value;
        }
        public string GetMake()
        {
            return make;
        }
        public void SetMake(string value)
        {
            make = value;
        }
        public string GetGearbox()
        {
            return gearbox;
        }
        public void SetGearbox(string value)
        {
            gearbox = value;
        }
    }
}
