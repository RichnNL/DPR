using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class FJREngine : IEngine
    {
        public int Displacement { get; set; }
        public string type { get; set; }

        public FJREngine()
        {
            Displacement = 1298;
            type = "liquid-cooled DOHC inline 4-cylinder; 16 valves";
        }

        public string toString()
        {
            return " a " + Displacement + " cc engine with " + type;
        }
    }
}

