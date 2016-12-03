using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class _7Series : BMW
    {

        public List<string> possibleAccessories;
        public _7Series()
        {
            possibleAccessories = new List<string>();
            possibleAccessories.Add("ParkAssist");
            possibleAccessories.Add("CarbonBrakes");
            possibleAccessories.Add("loudspeakers");
        }
        public string getDescription()
        {
            string descprition = "  The latest 7 Series, launched in 2015, is BMW's most luxurious car. Now in its sixth generation, it's a limousine that also appeals to owner-drivers. ";
            return descprition;
        }

        public decimal getPrice()
        {
            decimal price = 56955;
            return price;
        }
        public string getImage()
        {
            string im = "7Series";
            return im;
        }
        public List<string> getPossibleAccessories()
        {
            return possibleAccessories;
        }
    }
}
