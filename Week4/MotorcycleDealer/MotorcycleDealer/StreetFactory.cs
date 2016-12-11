using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MotorcycleDealer
{
    interface StreetFactory
    {
        IEngine addEngine();
        Image setImage();
        decimal setPrice();
        
    }
}
