using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateApplication
{
    public class Player
    {
        PlayerState Winning;
        PlayerState Losing;
        PlayerState Neutral;

        PlayerState playerState;
        string playerName;
        public int chips;
        int playerNumber;
        public int turn;
        public bool InRound;
        public Card card1;
        public Card card2;
        public int allIn;
        public int amountCalled;

        public Player(string PlayerName, int starting_chips, int playerNumber)
        {
            Winning = new WinningPlayer(this);
            Losing = new LosingPlayer(this);
            Neutral = new NeturalPlayer(this);
            this.amountCalled = 0;
            this.playerName = PlayerName;
            this.chips = starting_chips;
            this.playerState = Neutral;
            this.playerNumber = playerNumber;
            turn = 0;
            InRound = true;
            allIn = 0;
        }
        public int getPlayerNumber()
        {
            return playerNumber;
        }
        public string getPlayerName()
        {
            return playerName;
        }
        public int getPlayerChips()
        {
            return chips;
        }
        public void setPlayerState(State state)
        {
            if (state.Equals(State.Winner))
            {
                this.playerState = Winning;
            }
            else if (state.Equals(State.Loser))
            {
                this.playerState = Losing;
            }
            else
            {
                this.playerState = Neutral;
            }
        }
        public int call(int callAmount)
        {
            callAmount -= amountCalled;
            chips -= callAmount;
            amountCalled += callAmount;
            return callAmount;
        }
        public int raise(int amount, Player loser)
        {
            return playerState.Raise(amount, loser);
        }
        public void fold(Player loser)
        {
           playerState.Fold(loser);
        }
        public void check(Player loser)
        {
            playerState.Check(loser);
        }
        public State getState()
        {
            if(playerState == Winning)
            {
                return State.Winner;
            }
            else if(playerState == Losing)
            {
                return State.Loser;
            }
            else
            {
                return State.Neutral;
            }
        }

        
    }
}
