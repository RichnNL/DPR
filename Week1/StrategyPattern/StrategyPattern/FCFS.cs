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
            //If First Processess Arrival time is not 0
            if(Convert.ToInt32(data[0][2]) != 0)
            {
                int firstArrival = Convert.ToInt32(data[0][2]);
                string[] empty = { "Empty Process", firstArrival.ToString(), 0.ToString(), "white" };
                data.Insert(0, empty);
                previousBurst = firstArrival;
                data[1][3] = previousBurst.ToString();
            }
            else
            {
                data[0][3] = previousBurst.ToString();
            }
            //Calculates the waiting time
            
            for(int i = 1; i < data.Count; i++)
            {
                previousBurst = previousBurst + Convert.ToInt32(data[i-1][1]);
                int wait = previousBurst - Convert.ToInt32(data[i][2]);
                data[i][3] = wait.ToString();
            }
            
            return data;
        }
    }
}
