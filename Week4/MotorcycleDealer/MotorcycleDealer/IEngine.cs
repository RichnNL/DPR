using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleDealer
{
    public interface IEngine
    {
         int Displacement { get; set; }
        string type { get; set; }
        string toString();

    }
}
