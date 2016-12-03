using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class M6Coupe : BMW
    {

        public List<string> possibleAccessories;
        public M6Coupe()
        {
            possibleAccessories = new List<string>();
            possibleAccessories.Add("ParkAssist");
            possibleAccessories.Add("CarbonBrakes");
            possibleAccessories.Add("loudspeakers");
        }
        public string getDescription()
        {
            string descprition =" Blending a tasteful yet aggressive design with extraordinary performance,";  
                     descprition += "the M6 is a sexy beast indeed.Power comes from a 560 - hp 4.4 - liter twin";
            descprition += "- turbo V - 8 mated to a seven-speed automatic or six - speed manual.";
            return descprition;
        }

        public decimal getPrice()
        {
            decimal price = 114695 ;
            return price;
        }
        public string getImage()
        {
            string im = "m6coupe";
            return im;
        }
        public List<string> getPossibleAccessories()
        {
            return possibleAccessories;
        }
    }
}
