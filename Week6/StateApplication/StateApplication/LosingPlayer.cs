using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateApplication
{
    class LosingPlayer : PlayerState
    {
        Player player;

        public LosingPlayer(Player player)
        {
            this.player = player;
        }
        public void Check(Player loser)
        {
           
        }

        public void Fold(Player loser)
        {
          
        }

        public int Raise(int amount, Player loser)
        {
            player.chips -= amount;
            return amount;
        }
    }
}
