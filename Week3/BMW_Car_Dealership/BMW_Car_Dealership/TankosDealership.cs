using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    class TankosDealership
    {
        public List<BMW> stock;
       
        public TankosDealership()
        {
            stock = new List<BMW>();
            stock.Add(new _2SeriesCoupe());
            stock.Add(new _7Series());
            stock.Add(new I8());
            stock.Add(new Z4());
            stock.Add(new M6Coupe());

            
        }
    }
}
