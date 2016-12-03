using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Car_Dealership
{
    interface BMW
    {

        decimal getPrice();
        string getDescription();

        string getImage();

        List<string> getPossibleAccessories();



    }
}
