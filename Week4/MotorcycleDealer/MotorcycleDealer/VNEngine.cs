using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class VNEngine : IEngine
    {
        public int Displacement { get; set; }
        public string type { get; set; }

        public VNEngine()
        {
            Displacement = 2000;
            type = "8v V-twin, 5 gears";
        }

        public string toString()
        {
            return " a " + Displacement + " cc engine with " + type;
        }
    }
}
