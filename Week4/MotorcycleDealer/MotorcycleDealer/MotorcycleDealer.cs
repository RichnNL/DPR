using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class MotorcycleDealer : MotorCycleBuilder
    {
        protected override Motorcycle makeMotorcycle(string type, string model)
        {
            Motorcycle motorcycle = null; 
            if (type == "Cruiser")
            {
                CruiserFactory factory = null;
                if (model == "FJR1300")
                {
                    factory = new FJRFactory();
                }
                else if(model == "Vulcan")
                {
                    factory = new VulcanFactory();
                }
                motorcycle = new CruiserMotorCycle(factory);
            }
            else if(type == "Street")
            {
                StreetFactory factory = null;
                if (model == "Diavel")
                {
                    factory = new DiavelFactory();
                }
                else if(model == "VN2000"){
                    factory = new VN2000Factory();
                }
                motorcycle = new StreetMotorcycle(factory);
            }
        
            else if (type == "Racer")
            {
                RaceFactory facotry = null;
                if(model == "R1")
                {
                    facotry = new R1Factory();
                }
                else if (model == "Zx6")
                {
                    facotry = new NinjaZX6RFactory();
                }
                motorcycle = new RaceMotorCycle(facotry);

            }
            return motorcycle;
        }

       

    }
}
