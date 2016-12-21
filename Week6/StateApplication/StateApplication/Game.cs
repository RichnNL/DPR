using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateApplication
{
    public class Game
    {
        int numberofplayers;
        int ChipsToWin;
        public int pot;
        public int callAmount;
        List<Player> players;
        List<Player> playersInGame;
        Player WinningPlayer;
        Player LosingPlayer;
        Deck deck;
        private int playersTurn;
        private int round;
        private bool aRoundWinner;
        GameBoard board;
        public int Round { get { return round; }
                           set { }
        }
        public int CurrentPlayersTurn { get { return playersTurn; }
            set { if(value < 1 || value > numberofplayers)
                {
                    playersTurn = 1;
                }
                else
                {
                    playersTurn = value;
                }
            ;}
        }

      

        public Game(int NumberOfPlayers,int ChipsNeededToWin,GameBoard gameboard)
        {
            this.numberofplayers = NumberOfPlayers;
            this.deck = new Deck();
            this.ChipsToWin = ChipsNeededToWin;
            playersTurn = 1;
            players = new List<Player>();
            this.board = gameboard;
        }
        public void addPlayer(Player player)
        {
            players.Add(player);
        }
        public int getNumberOfPlayers()
        {
            return numberofplayers;
        }
        private void nextPlayerOrder()
        {
            Player temp = players[players.Count - 1];
            Player temp2 = players[0];
            for (int i = 0; i< players.Count; i++)
            {    
                if(i == 0)
                {
                    players[i] = temp;
                    temp = temp2;
                }
                else
                {
                    temp2 = players[i];
                    players[i] = temp;
                    temp = temp2;
                }
               
            }
        }
        public Player getCurrentPlayer()
        {
           return players[CurrentPlayersTurn];
        }
        public Player getPlayer(int PlayerNumber)
        {
            foreach( Player p in players)
            {
                if(p.getPlayerNumber() == PlayerNumber)
                {
                    return p;
                }
            }
            return null;
        }
        public void RunGame()
        {
            foreach(Player p in players)
            {
                p.turn = 0;
                p.InRound = true;
                p.allIn = 0;
            }
            while (!checkIfPlayerWon())
            {
                RoundOne();
                if (!aRoundWinner)
                {
                    RoundTwo();
                }
                
            }
        }
        public void RoundOne()
        {
            aRoundWinner = false;
            playersInGame = players;
            while (!everyoneTurnComplete())
            {
                board.PlayerTurn(getCurrentPlayer().getPlayerNumber());
            }
            foreach(Player p in playersInGame)
            {
                drawCard(p.getPlayerNumber(), 1);
                board.showCard(p.getPlayerNumber(), 1);
                p.turn = 0;
            }
           

        }
        public void RoundTwo()
        {
            while (!everyoneTurnComplete())
            {
                board.PlayerTurn(getCurrentPlayer().getPlayerNumber());
            }
            foreach (Player p in playersInGame)
            {
                drawCard(p.getPlayerNumber(), 1);
                board.showCard(p.getPlayerNumber(), 1);
            }
            Player winner = playersInGame[0];
            foreach(Player p in playersInGame)
            {
                int value1 = p.card1.getValue() + p.card2.getValue();
                if(value1 > (winner.card1.getValue() + winner.card2.getValue()))
                {
                    winner = p;
                }
                else if(value1 == (winner.card1.getValue() + winner.card2.getValue()))
                {
                    if(p.getState() == State.Winner && p != winner)
                    {
                        winner = p;
                    }
                }
            }
            PlayerWonPot(winner);
        }
        public void restartRound()
        {

        }
        private void SetWinnerLoser()
        {
            Random random = new Random();
            int w = random.Next(0, numberofplayers);
            int l = random.Next(0, numberofplayers);
            while(w == l)
            {
                l = random.Next(0, numberofplayers);
            }
            Player TempWinner = players[w];
            Player TempLosing = players[l];
            for(int i = 0; i < players.Count; i++)
            {
                if(TempWinner.getPlayerChips() < players[i].getPlayerChips())
                {
                    TempWinner = players[i];
                }
                if(TempLosing.getPlayerChips() > players[i].getPlayerChips())
                {
                    TempLosing = players[i];
                }
            }
            if(WinningPlayer == null )
            {
                WinningPlayer = TempWinner;
                WinningPlayer.setPlayerState(State.Winner);
            }
            else if(WinningPlayer.getPlayerChips() < TempWinner.getPlayerChips())
            {
                WinningPlayer = TempWinner;
                WinningPlayer.setPlayerState(State.Winner);
            }
            if(LosingPlayer == null)
            {
                LosingPlayer = TempLosing;
                LosingPlayer.setPlayerState(State.Loser);
            }
            else if(LosingPlayer.getPlayerChips() < TempLosing.getPlayerChips())
            {
                LosingPlayer = TempLosing;
                LosingPlayer.setPlayerState(State.Loser);
            }
            foreach(Player p in players)
            {
                if(p != WinningPlayer || p != LosingPlayer)
                {
                    p.setPlayerState(State.Neutral);
                }
            }
        }
        private bool everyoneTurnComplete()
        {
            foreach(Player p in playersInGame)
            {
                if(p.turn == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void setNextPlayer()
        {
            if(playersInGame.Count == 1)
            {
                PlayerWonPot(playersInGame[0]);
            }
            else
            {
                CurrentPlayersTurn++;
                bool inGame = false;
                while (!inGame)
                {
                    foreach (Player p in playersInGame)
                    {
                        if (p.getPlayerNumber() == CurrentPlayersTurn && p.InRound)
                        {
                            inGame = true;
                        }
                    }
                    CurrentPlayersTurn++;
                }
            }
            
        
        }
        public void PlayerWonPot(Player player)
        {
            aRoundWinner = true;
            if(player.allIn == 0)
            {
                player.chips += pot;
            }
            else
            {
                player.chips += player.allIn;
                pot -= player.allIn;
                Player winner = playersInGame[0];
                if(winner == player && playersInGame.Count > 1)
              //  { iam here
                    winner = playersInGame[1];
                }
                foreach (Player p in playersInGame)
                {
                    if(p != player)
                    {
                        int value1 = p.card1.getValue() + p.card2.getValue();
                        if (value1 > (winner.card1.getValue() + winner.card2.getValue()))
                        {
                            winner = p;
                        }
                        else if (value1 == (winner.card1.getValue() + winner.card2.getValue()))
                        {
                            if (p.getState() == State.Winner)
                            {
                                winner = p;
                            }
                        }
                    }
                    
                }
            }
        }
        private void drawCard(int player, int card)
        {
            if(card == 1)
            {
                getPlayer(player).card1 = deck.pullCard();
            }
            else if( card == 2)
            {
                getPlayer(player).card2 = deck.pullCard();
            }


        }
        public void playerOut(Player player)
        {
            playersInGame.Remove(player);
        }
        public Player getLoser()
        {
            return LosingPlayer;
        }
        private bool checkIfPlayerWon()
        {
            foreach(Player p in players)
            {
                if(p.getPlayerChips() >= ChipsToWin)
                {
                  DialogResult result =  MessageBox.Show("Player:" + p.getPlayerName() + "has won the game with " + p.getPlayerChips() + "chips" + "Press ok to play again");
                    if(result == DialogResult.OK)
                    {
                        board.Parent.Show();
                        board.Close();
                        return true;
                    }
                    else
                    {
                        board.Close();
                    }
                }
                if(p.getPlayerChips() <= 0)
                {
                    players.Remove(p);
                }
            }
            return false;
        }
    }
}
