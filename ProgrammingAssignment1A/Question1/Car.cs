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
        public void SetColour(string col)
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
