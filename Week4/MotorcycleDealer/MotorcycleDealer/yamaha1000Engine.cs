using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class yamaha1000Engine : IEngine
    {
       public int Displacement { get; set; }
       public string type { get; set; }

        public yamaha1000Engine()
        {
            Displacement = 1000;
            type = "liquid cooled, 4 stroke, cylinder, 4 valves";
        }

        public string toString()
        {
            return " a " + Displacement + " cc engine with " + type;
        }
    }
}
