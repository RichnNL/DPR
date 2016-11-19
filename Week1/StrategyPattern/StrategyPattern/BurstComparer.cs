using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class BurstComparer : IComparer<string[]>
    {
        public int Compare(string[] x, string[] y)
        {
            int xx = Convert.ToInt32(x[1]);
            int yy = Convert.ToInt32(y[1]);
            if (xx > yy)
            {
                return 1;
            }
            else if (xx < yy)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
