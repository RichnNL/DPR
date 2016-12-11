using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class kawasaki600Engine : IEngine
    {
        public int Displacement { get; set; }
        public string type { get; set; }

        public kawasaki600Engine()
        {
            Displacement = 636;
            type = "liquid cooled, 4 stroke, cylinder, 4 valves";
        }

        public string toString()
        {
            return " a " + Displacement + " cc engine with " + type;
        }
    }
}
