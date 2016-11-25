using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class City
    {
        private string Name;
        private int percentageChance;
        private bool isRaining;

        public City(string Name, int percentageChance)
        {
            this.Name = Name;
            this.percentageChance = percentageChance;
        }
        public string getCityName()
        {
            return Name;
        }
        public int getPercentageChance()
        {
            return percentageChance;
        }
        public bool getisRaining()
        {
            return isRaining;
        }
        public void setIsRaining(bool isRaining)
        {
            this.isRaining = isRaining;
        }
    }
}
