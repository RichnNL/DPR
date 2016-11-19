using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Shortest : Process
    {
        public Shortest(ProcessBehavior processBehavior)
        {
            pb = processBehavior;
        }
    }
}
