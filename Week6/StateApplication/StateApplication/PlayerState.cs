using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateApplication
{
    public interface PlayerState
    {
        void Check(Player loser);

        void Fold(Player loser);

        int Raise(int amount,Player loser);
    }
}
