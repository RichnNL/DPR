using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MotorcycleDealer
{
    interface RaceFactory
    {
        IEngine addEngine();
        int setMaximumSpeed();
        Image setImage();
        decimal setPrice();
    }
}
