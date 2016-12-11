using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MotorcycleDealer
{
    class FJRFactory : CruiserFactory
    {
        public IEngine addEngine()
        {
            return new FJREngine();
        }

        public Image setImage()
        {
            return Properties.Resources.FJR1300;
        }

        public int setMaximumDistance()
        {
            return 260;
        }

        public decimal setPrice()
        {
            return 16500;
        }
    }
}
