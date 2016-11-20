using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Non_pre : ProcessBehavior
    {
        // Data Array 0 Process Name, 1 Burst, 2 Oringal Arrival Time, 3 Waiting Time , 4 Color of Process
        public List<string[]> handleRequest(List<string[]> data)
        {
            List<string[]> finalList = new List<string[]>();
            List<string[]> ArrivedList = new List<string[]>();
           
            int previousBurst = 0;
            ProcessCompar PC = new ProcessCompar();
            BurstComparer BC = new BurstComparer();
            //Sorts by the arrival time
            data.Sort(PC);

            //If First Processess Arrival time is not 0
            if (Convert.ToInt32(data[0][2]) != 0)
            {
                int firstArrival = Convert.ToInt32(data[0][2]);
                string[] empty = { "Empty Process", firstArrival.ToString(), 0.ToString(), "white" };
                finalList.Add(empty);
            }

            //Store the first arrival 
            finalList.Add(data[0]);
            data.Remove(data[0]);

            previousBurst = Convert.ToInt32(finalList[0][1]);
            int count = data.Count;
            for(int i = 0; i < count; i++)
            {
                //See what Processes Have arrived and puts them in list
                if (data.Count != 0)
                {
                    List<int> delete = new List<int>();
                    for(int j = 0; j< data.Count; j++)
                    {
                        if (Convert.ToInt32(data[j][2]) <= previousBurst)
                        {
                            ArrivedList.Add(data[j]);
                            delete.Add(j);
                        }

                    }
                    //Deletes arrived 
                    for(int k = 0; k < delete.Count; k++)
                    {
                        data.Remove(data[delete[k]-k]);
                    }
                }
                //Sorts Arrived List by shortest burst times and adds too final list
                ArrivedList.Sort(BC);
                //Updates processTime
                if (ArrivedList.Count != 0)
                {
                    previousBurst = previousBurst + Convert.ToInt32(ArrivedList[0][1]);
                    finalList.Add(ArrivedList[0]);
                    ArrivedList.Remove(ArrivedList[0]);
                }
            }
            //Calculate Waiting Time
            previousBurst = 0;
            foreach (var v in finalList)
            {
                if (previousBurst == 0)
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
            return finalList;
        }
    }

}
