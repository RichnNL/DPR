using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface ISubject
    {
        void Attach(IObserver o);
        void Detach(IObserver o);

        void Notify();
    }
}
