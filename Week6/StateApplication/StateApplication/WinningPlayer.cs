using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateApplication
{
    class WinningPlayer : PlayerState
    {
        Player player;

        public WinningPlayer(Player player)
        {
            this.player = player;
        }
        public void Check(Player loser)
        {
            int tax = (player.chips * 5) / 100;
            player.chips -= tax;
            loser.chips = +tax;
        }

        public void Fold(Player loser)
        {
            int tax = (player.chips * 5) / 100;
            player.chips -= tax;
            loser.chips = +tax;
        }

        public int Raise(int amount, Player loser)
        {
            int tax = (player.chips * 5) / 100;
            player.chips -= amount + tax;
            loser.chips += tax;
            return amount;
        }
    }
}
