using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class DuvelEngine : IEngine
    {
       
        public int Displacement { get; set; }
        public string type { get; set; }

        public DuvelEngine()
        {
            Displacement = 1100;
            type = " L-Twin, 4 Desmodromically actuated valves per cylinder, liquid cooled";
        }

        public string toString()
        {
            return " a " + Displacement + " cc engine with " + type;
        }
    }
}
