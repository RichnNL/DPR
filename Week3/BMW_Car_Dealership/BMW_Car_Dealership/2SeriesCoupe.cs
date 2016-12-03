using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class _2SeriesCoupe : BMW
    {
        public List<string> possibleAccessories;
        public _2SeriesCoupe()
        {
            possibleAccessories = new List<string>();
            possibleAccessories.Add("ParkAssist");
            possibleAccessories.Add("CarbonBrakes");
            possibleAccessories.Add("loudspeakers");
        }
        public string getDescription()
        {
            string descprition = "Feisty characteristics: the striking crease line originates behind the front axle,";
            descprition += "  runs upwards in the rear wing and emphasises the sporty-dynamic wedge shape.";
            descprition += "Combined with the muscular wheel housings it proves that the BMW 2 Series Coupé is always ready to take the lead.";
            return descprition;
        }

        public decimal getPrice()
        {
            decimal price = 23040;
            return price;
        }
        public string getImage()
        {
            string im = "2Series";
            return im;
        }
        public List<string> getPossibleAccessories()
        {
            return possibleAccessories;
        }
    }
}
