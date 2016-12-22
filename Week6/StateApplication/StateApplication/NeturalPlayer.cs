using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateApplication
{
    class NeturalPlayer : PlayerState
    {
        Player player;

        public NeturalPlayer(Player player)
        {
            this.player = player;
        }
        public void Check(Player loser)
        {
            if(loser != null)
            {
                int tax = (player.chips * 1) / 100;
                player.chips -= tax;
                loser.chips += tax;
            }
          
        }

        public void Fold(Player loser)
        {
            if (loser != null)
            {
                int tax = (player.chips * 1) / 100;
                player.chips -= tax;
                loser.chips += tax;
            }
        }

        public int Raise(int amount, Player loser)
        {
            if(loser != null) {
                int tax = (player.chips * 1) / 100;
                player.chips -= amount + tax;
                loser.chips += tax;
                return amount;
            }
            else
            {
                player.chips -= amount;
                return amount;
            }
          
        }
    }
}
