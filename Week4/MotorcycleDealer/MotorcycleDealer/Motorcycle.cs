using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MotorcycleDealer
{
    public abstract class Motorcycle
    {
        
        private decimal price;
       
        
        public IEngine engine;

        public Motorcycle()
        {
         
        }
        public abstract void makeMotocycle();
        public virtual string showDetails()
        {  
                return   " has " + engine.toString() + " and costs " + price;
        }
        public abstract Image getImage();
     
        public void setPrice(decimal price)
        {
            this.price = price;
        }
        public decimal getPrice()
        {
            return this.price;
        }


    }
}
