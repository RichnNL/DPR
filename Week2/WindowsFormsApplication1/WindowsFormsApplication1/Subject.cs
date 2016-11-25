using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class WeatherSubject : ISubject
    {
        Random r;
        List<City> Cities;
        public WeatherSubject()
        {
            r = new Random();
            Cities = new List<City>();
        }
        public void Attach(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void Detach(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        private bool CalculateRain(City city)
        {
            int chance = r.Next(1, 101);
            if(chance > city.getPercentageChance())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
