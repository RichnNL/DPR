﻿using System;
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
            return data;
        }
    }
}

