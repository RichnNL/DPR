using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprWeek2
{
    class WeatherPrediction : ISubject
    {
        //variables
        List<IObserver> observers;
        Random r;
        int temperature;

        public int Temperature { get; set; }
        // constructor
        public WeatherPrediction()
        {
            observers = new List<IObserver>();
            r = new Random();

        }


        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver ob in observers)
            {
                ob.update();
            }
        }
        // if the random number is bigger than 50 then it rains ... 
        public bool CalculateRain()
        {
            int chance = r.Next(1, 101);
            if (chance < 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // changes the values of temp and invokes the Calc rain method
        public void Changer(int temper)
        {
            temperature = temper;
            CalculateRain();

        }

    }
}