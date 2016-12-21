using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
   interface ICustomIterator
    {
        bool HasNext();
        object Next();
        object Previous();

    }
}
