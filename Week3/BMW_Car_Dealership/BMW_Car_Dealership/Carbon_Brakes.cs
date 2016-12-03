using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class Carbon_Brakes : Accessories
    {
        public Carbon_Brakes(BMW bmw) :base(bmw)
        {

        }
        public override string getDescription()
        {
            string description = "Carbon brakes offer a significant weight savings compared to steel brakes.";
                description += "This translates into a lighter airplane, which directly contributes to decreased fuel";
                description += "consumption and associated reductions in engine emissions.";
              
            return description;
        }

        public override string getImage()
        {
            string image = "CarbonBrakes";
            return image;
        }

        public override decimal getPrice()
        {
            decimal price = 8150;

            return base.getPrice() + price;
        }


    }
}

