using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MotorcycleDealer
{
    class DiavelFactory : StreetFactory
    {
        public IEngine addEngine()
        {
            return new DuvelEngine();
        }

        public Image setImage()
        {
            return Properties.Resources.DucatiDiavel;
        }

        public decimal setPrice()
        {
            return 18500;
        }
    }
}
