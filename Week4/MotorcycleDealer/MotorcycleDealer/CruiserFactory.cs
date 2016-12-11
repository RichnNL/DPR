using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MotorcycleDealer
{
    interface CruiserFactory
    {
        IEngine addEngine();
        int setMaximumDistance();
        Image setImage();
        decimal setPrice();

    }
}
