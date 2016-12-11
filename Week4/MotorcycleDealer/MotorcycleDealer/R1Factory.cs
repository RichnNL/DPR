using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MotorcycleDealer
{
    class R1Factory : RaceFactory
    {
        public IEngine addEngine()
        {
            return new yamaha1000Engine();
        }

        public Image setImage()
        {
            return Properties.Resources.YZFR1;
        }

        public int setMaximumSpeed()
        {
            return 288;
        }

        public decimal setPrice()
        {
            return 19000;
        }
    }
}
