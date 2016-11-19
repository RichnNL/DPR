using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FirstCome : Process
    {
        public FirstCome(ProcessBehavior processBehavior)
        {
            pb = processBehavior;
        }
    }
}
