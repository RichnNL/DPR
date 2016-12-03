using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class ParkAssist : Accessories
    {
        
        public ParkAssist(BMW bmw) : base(bmw)
        {
          

        }
        public override string getDescription()
        {

            string descrption = "The Park Assist makes parking parallel and perpendicular to the road easier. Whether activated or not, the system measures potential spaces – even tight parallel parking spaces – while driving past at a low speed (below 20mph) and at a maximum distance of 1.5 m from the row of parked cars. ";
            return descrption;
        }

        public override string getImage()
        {
            string image = "ParkAssist";
            return image;
        }

        public override decimal getPrice()
        {
            decimal price = 255;

            return base.getPrice() + price;
        }


    }
}

