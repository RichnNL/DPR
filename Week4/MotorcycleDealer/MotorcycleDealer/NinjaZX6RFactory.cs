using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    class NinjaZX6RFactory : RaceFactory
    {
        public IEngine addEngine()
        {
            return new kawasaki600Engine();
        }

        public Image setImage()
        {
            return Properties.Resources.zx6;
        }

        public int setMaximumSpeed()
        {
           return 267;
        }

        public decimal setPrice()
        {
            return 12000;
        }
    }
}
