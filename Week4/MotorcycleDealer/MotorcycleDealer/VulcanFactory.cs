using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MotorcycleDealer
{
    class VulcanFactory : CruiserFactory
    {
        public IEngine addEngine()
        {
            return new VulcanEngine();
        }

        public Image setImage()
        {
            return Properties.Resources.vulcan;
        }

        public int setMaximumDistance()
        {
            return 297;
        }

        public decimal setPrice()
        {
            return 18500;
        }
    }
}
