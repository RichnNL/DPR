using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Songs
    {
        public string Name;
        public string Band;
        public int Year;
        public Songs(string name, string band, int year)
        {
            Name = name;
            Band = band;
            Year = year;
        }
        public override string ToString()
        {
            return Name + " - " + Band + Year.ToString();
        }
    }
}
