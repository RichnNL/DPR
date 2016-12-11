using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class VulcanEngine : IEngine
    {
        public int Displacement { get; set; }
        public string type { get; set; }

        public VulcanEngine()
        {
            Displacement = 1700;
            type = "4-stroke, 52° V-twin, liquid-cooled";
        }

        public string toString()
        {
            return " a " + Displacement + " cc engine with " + type;
        }
    }
}
