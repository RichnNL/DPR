using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class TsankosMotorCycleDealship
    {
        public List<List<string>> type;
        public MotorCycleBuilder dealer;

        public TsankosMotorCycleDealship()
        {
            dealer = new MotorcycleDealer();
            type = new List<List<string>>();

            List<string> Cruiser = new List<string>();
            Cruiser.Add("Cruiser");
            Cruiser.Add("Vulcan");
            Cruiser.Add("FJR1300");


            List<string> Racer = new List<string>();
            Racer.Add("Racer");
            Racer.Add("Zx6");
            Racer.Add("R1");

            List<string> Street = new List<string>();
            Street.Add("Street");
            Street.Add("Diavel");
            Street.Add("VN2000");

            type.Add(Cruiser);
            type.Add(Street);
            type.Add(Racer);

        }
    }
}
