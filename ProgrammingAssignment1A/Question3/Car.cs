using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Car
    {
        public string Colour { get; set; } //created auto-implemented properties - private properties created in runtime
        public string Make { get; set; } //auto-implemented properties set and return property values without additional code
        public string Gearbox { get; set; }
    }
}
