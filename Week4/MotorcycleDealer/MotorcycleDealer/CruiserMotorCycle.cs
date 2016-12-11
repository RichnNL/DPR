using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class CruiserMotorCycle : Motorcycle
    {
        private int maximumDistance;
        CruiserFactory factory;

        public CruiserMotorCycle(CruiserFactory factory)
        {
            this.factory = factory;
        }
        public override Image getImage()
        {
            return factory.setImage();
        }


        public override void makeMotocycle()
        {
            setmaximumDistance(factory.setMaximumDistance());
            this.engine = factory.addEngine();
            setPrice(factory.setPrice());
        }
        public void setmaximumDistance(int speed)
        {
            this.maximumDistance = speed;
        }
        public override string ToString()
        {
            return getModel() + " has " + engine.toString() + " and can go a maximum distance of " + maximumDistance + " and costs " + getPrice();
        }
     }
    }

