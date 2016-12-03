using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class Z4 : BMW
    {
        public List<string> possibleAccessories;
        public Z4()
        {
            possibleAccessories = new List<string>();
            possibleAccessories.Add("ParkAssist");
            possibleAccessories.Add("CarbonBrakes");
            possibleAccessories.Add("loudspeakers");
        }
        public string getDescription()
        {
            string descprition = "  sports car of the classic mould with two seats, a petrol engine and rear-wheel drive. ";
            descprition += "Targeted more at the luxury touring market than the hard-edged sporting one";
            return descprition;
        }

        public decimal getPrice()
        {
            decimal price = 50695;
            return price;
        }
        public string getImage()
        {
            string im = "z4";
            return im;
        }
        public List<string> getPossibleAccessories()
        {
            return possibleAccessories;
        }
    }
}
