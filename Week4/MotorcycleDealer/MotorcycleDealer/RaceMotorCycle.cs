using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class RaceMotorCycle : Motorcycle
    {
        private int maximumSpeed;
        RaceFactory factory;

        public RaceMotorCycle(RaceFactory factory)
        {
            this.factory = factory;
        }
        public override Image getImage()
        {
            return factory.setImage();
        }


        public override void makeMotocycle()
        {
            setmaximumSpeed( factory.setMaximumSpeed());
            this.engine = factory.addEngine();
            setPrice(factory.setPrice());
        }
        public void setmaximumSpeed(int speed)
        {
            this.maximumSpeed = speed;
        }
        public override string ToString()
        {
            return base.getModel() + " has " + base.engine.toString() + " and can go a maximum speed of " + maximumSpeed + " and costs " + base.getPrice();
        }
    }
}
