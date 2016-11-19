using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   abstract class Process 
    {
        public ProcessBehavior pb;
        public List<string[]> processRequest(List<string[]> data)
        {
            List<string[]> Data = pb.handleRequest(data);
            return Data;
        }
    }
}
