using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MotorcycleDealer
{
    class VN2000Factory : StreetFactory
    {
        public IEngine addEngine()
        {
            return new VNEngine();
        }

        public Image setImage()
        {
            return Properties.Resources.VN2000jpg;
        }

        public decimal setPrice()
        {
            return 12000;
        }
    }
}
