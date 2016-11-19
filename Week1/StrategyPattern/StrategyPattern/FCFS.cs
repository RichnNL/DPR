using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FCFS : ProcessBehavior
    {
        // Data Array 0 Process Name, 1 Burst, 2 Oringal Arrival Time, 3 Waiting Time , 4 Color of Process
        public List<string[]> handleRequest(List<string[]> data)
        {
            
            int previousBurst = 0;
            ProcessCompar PC = new ProcessCompar();
            //Sorts by the arrival time
            data.Sort(PC);
            foreach (var v in data)
            {
                if(previousBurst == 0)
                {
                    previousBurst = previousBurst + Convert.ToInt32(v[1]);
                    v[3] = 0.ToString();
                }
                else
                {
                    int waitingtime = previousBurst - Convert.ToInt32(v[2]);
                    previousBurst = previousBurst + Convert.ToInt32(v[1]);
                    v[3] = waitingtime.ToString();
                }
               
                
            }
            return data;
        }
    }
}
