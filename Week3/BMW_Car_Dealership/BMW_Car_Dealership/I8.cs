using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class I8 : BMW
    {

        public List<string> possibleAccessories;
        public I8()
        {
            possibleAccessories = new List<string>();
            possibleAccessories.Add("ParkAssist");
            possibleAccessories.Add("CarbonBrakes");
            possibleAccessories.Add("loudspeakers");
        }
        public string getDescription()
        {
            string descprition = "Three pistons combusting internally"; 
               descprition += "a dash of electrons and lots of aluminum and carbon fiber are the i8’s main ingredients.";
               descprition += "Its 357 - hp hybrid powertrain drives all four wheels; in our hands, the i8 hit 60 mph in 4.0 seconds";
            return descprition;
        }

        public decimal getPrice()
        {
            decimal price = 141695;
            return price;
        }
        public string getImage()
        {
            string im = "I8";
            return im;
        }
        public List<string> getPossibleAccessories()
        {
            return possibleAccessories;
        }


    }
}
