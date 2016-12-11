using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    public abstract class MotorCycleBuilder
    {
        protected abstract Motorcycle makeMotorcycle(string type, string model);

        public Motorcycle orderMotorcycle(string type, string model)
        {
            Motorcycle motorcycle = makeMotorcycle(type, model);
            motorcycle.makeMotocycle();
            return motorcycle;
        }
    }
}
