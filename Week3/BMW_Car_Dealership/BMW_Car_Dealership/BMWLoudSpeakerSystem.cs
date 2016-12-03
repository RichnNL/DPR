using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class BMWLoudSpeakerSystem : Accessories
    {
        public BMWLoudSpeakerSystem(BMW bmw) :base(bmw)
        {
            
        }
        public override string getDescription()
        {
            
           string  descrption = "Updated BMW Sounds system";
                return descrption;
        }

        public override string getImage()
        {
            string image = "loudspeakers";
            return image;
        }

        public override decimal getPrice()
        {
            decimal price = 295;
            
            return base.getPrice() + price;
        }


    }
}
