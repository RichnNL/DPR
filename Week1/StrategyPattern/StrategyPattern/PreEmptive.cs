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
            List<string[]> tempList = data;
            List<string[]> finalList = new List<string[]>();
            List<string[]> arrivalList = new List<string[]>();
            int totalBurstTime = 0;
            int[] currentPosition = { 0, -1 }; //0 = ArrivalList Position, 1 = finalList Position
            int previousBurst = 0;
            //Calculate Total BurstsTime in Processes
            foreach (var v in data)
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
                previousBurst = firstArrival;
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
                        if (Convert.ToInt32(data[j][2]) >= i)
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
            

            //Make list of processes that appear twice
            // string[] 0 = name, after positions it appears in array
            List<string[]> twice = new List<string[]>();
            foreach(var v in finalList)
            {
                int count = 0;
                bool inlist = false;
                foreach(var t in twice)
                {
                    if (t[0] == v[0])
                        inlist = true;
                }
                if (!inlist) //Not already in the list
                { //Count how many times and where else process is located in list
                    List<string> temp = new List<string>();
                    temp.Add(v[0]);
                   for(int z = 0; z < finalList.Count; z++)
                    {   
                        if(v[0] == finalList[z][0])
                        {
                            count++;
                            temp.Add(z.ToString());
                        }
                    }
                   if(count > 1)
                    {
                        twice.Add(temp.ToArray());
                    }
                }
            }
            List<string[]> finishingTime = twice;
            foreach(var p in finishingTime)
            {
                for(int i = 1; i < p.Length; i++)
                {
                    p[i] = 0.ToString();
                }
            }
            //Calculate Average Waiting Time 
            for (int i = 0; i < finalList.Count; i++)
            {
                bool inlist = false;
                foreach (var t in twice)
                {
                    if (t[0] == finalList[i][0])
                        inlist = true;
                }
                if (inlist)
                {
                    for(int p = 0; p < finishingTime.Count;)
                    {
                        if(finishingTime[p][0] == finalList[i][0])
                        {
                            for(int k = 0; k < finishingTime[p].Length; k++)
                            {
                                if(Convert.ToInt32(finishingTime[p][k]) == 0)
                                {
                                    finishingTime[p][k] = Convert.ToString(previousBurst + Convert.ToInt32(finalList[i][1]));
                                }
                            }
                        }
                    }
                }
                else
                {
                    int waitingtime = previousBurst - Convert.ToInt32(finalList[i][2]);
                    if (waitingtime < 0)
                    {
                        waitingtime = 0;
                    }
                    finalList[i][3] = previousBurst.ToString();
                    
                }
                previousBurst = previousBurst + Convert.ToInt32(finalList[i][1]);
            }
            //Calculate the Processes that appeared twice
            for(int p = 0; p < twice.Count; p++)
            {
                
                int completionTime = Convert.ToInt32(finishingTime[p][finishingTime[p].Length - 1]);
                int at = 0, bt = 0;
                foreach(var t in tempList)
                {
                    if(finishingTime[p][0] == t[0])
                    {
                        at = Convert.ToInt32(t[2]);
                        bt = Convert.ToInt32(t[1]);
                    }
                }
                int tat = completionTime - at;

                int waitingtime = tat - bt;
                if(waitingtime < 0)
                {
                    waitingtime = 0;
                }
                foreach(var v in finalList)
                {
                   if(v[0] == finishingTime[p][0])
                    {
                        v[3] = waitingtime.ToString();
                    }
                }

            }


                return finalList;
        }
    }
}

