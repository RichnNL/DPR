using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ProcessCompar : IComparer<string[]>
    {
        public int Compare(string[] x, string[] y)
        {
            
            int xx = Convert.ToInt32(x[2]);
            int yy = Convert.ToInt32(y[2]);
            if (xx == yy)
            {
                //If Arrival times are equal then compare shorter burst
                xx = Convert.ToInt32(x[1]);
                yy = Convert.ToInt32(y[1]);
            }
            if(xx > yy)
            {
                return 1;
            }
            else if(xx < yy)
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
