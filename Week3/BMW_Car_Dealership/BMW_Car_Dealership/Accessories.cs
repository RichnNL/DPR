using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    abstract class Accessories : BMW
    {
        public BMW bmw;
        public Accessories(BMW bmw)
        {
            this.bmw = bmw;
        }
        virtual public string getDescription()
        {
            return bmw.getDescription();
        }

        virtual public string getImage()
        {
            return bmw.getImage();
        }

        virtual public decimal getPrice()
        {
            
            return  bmw.getPrice();
        }

        public List<string> getPossibleAccessories()
        {
            return null;
        }
    }
}
