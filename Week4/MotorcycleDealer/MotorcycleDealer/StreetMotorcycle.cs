using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class StreetMotorcycle : Motorcycle
    {
        StreetFactory factory;

        public StreetMotorcycle(StreetFactory factory)
        {
            this.factory = factory;
        }
        public override Image getImage()
        {
            return factory.setImage();
        }


        public override void makeMotocycle()
        {
            this.engine = factory.addEngine();
            setPrice(factory.setPrice());
        }
    }
}
