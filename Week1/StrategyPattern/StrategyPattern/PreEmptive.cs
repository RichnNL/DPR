using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class PreEmptive : ProcessBehavior
    {
        public List<string[]> handleRequest(List<string[]> data)
        {
            // Data Array 0 Process Name, 1 Burst, 2 Oringal Arrival Time, 3 Waiting Time , 4 Color of Process
            bool isNewProcess = true;
            List<string[]> finalList = new List<string[]>();
            List<string[]> arrivalList = new List<string[]>();
            int totalBurstTime = 0;
            int[] currentPosition = { 0, -1 }; //0 = ArrivalList Position, 1 = finalList Position

            //Calculate Total BurstsTime in Processes
            foreach(var v in data)
            {
                totalBurstTime = totalBurstTime + Convert.ToInt32(v[1]);
            }
            ProcessCompar PC = new ProcessCompar();

            //Sort Processes by Arrival Time and Burst
            data.Sort(PC);

            //If First Processess Arrival time is not 0
            if (Convert.ToInt32(data[0][2]) != 0)
            {
                int firstArrival = Convert.ToInt32(data[0][2]);
                string[] empty = { "Empty Process", firstArrival.ToString(), 0.ToString(), "white" };
                finalList.Add(empty);
                currentPosition[1]++;
            }
            //Add First Instance To Arrival List
            arrivalList.Add(data[0]);
            data.Remove(data[0]);

            for(int i = Convert.ToInt32(arrivalList[0][2]); i < totalBurstTime; i++)
            {
                if (isNewProcess)
                {
                    string[] temp = { arrivalList[currentPosition[0]][0], 0.ToString(), arrivalList[currentPosition[0]][2], 0.ToString(), arrivalList[currentPosition[0]][4] };
                    finalList.Add(temp);
                    currentPosition[1]++;
                    isNewProcess = false;
                }
                //Add 1 burst to final list
                int b = Convert.ToInt32(finalList[currentPosition[1]][1]);
                b++;
                finalList[currentPosition[1]][1] = b.ToString();
                //Substracts the burst from arrival list
                int  a = Convert.ToInt32(arrivalList[currentPosition[0]][1]);
                a--;
                arrivalList[currentPosition[0]][1] = a.ToString();

                //See what Processes Have arrived and puts them in list
                if (data.Count != 0)
                {
                    List<int> delete = new List<int>();
                    for (int j = 0; j < data.Count; j++)
                    {
                        if (Convert.ToInt32(data[j][2]) <= i)
                        {
                            arrivalList.Add(data[j]);
                            delete.Add(j);
                        }

                    }
                    //Deletes from data
                    for (int k = 0; k < delete.Count; k++)
                    {
                        data.Remove(data[delete[k] - k]);
                    }
                }
                //Check if Current Burst Time is 0 
                int c = Convert.ToInt32(arrivalList[currentPosition[0]][1]);
                if(c == 0)
                {
                    arrivalList.Remove(arrivalList[currentPosition[0]]);
                    //Check if current position was at the end of the List
                    if(currentPosition[0] == arrivalList.Count)
                    {
                        currentPosition[0] = 0;
                    }
                    isNewProcess = true;
                }
                //Check if Current Process has the smallest Burst Time

                for(int z = 0; z < arrivalList.Count; z++)
                {
                    int cp = Convert.ToInt32(arrivalList[currentPosition[0]][1]);
                    int np = Convert.ToInt32(arrivalList[z][1]);
                    if (np < cp)
                    {
                        currentPosition[0] = z;
                        isNewProcess = true;
                    }
                }




            }
              

            return finalList;
        }
    }
}

