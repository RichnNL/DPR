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
                           set {
                                round = value;
                                if (round == 0)
                                {
                                RoundStart();
                                }
                                else if(round == 1)
                                 {
                                 RoundOne();
                                 }
                                else if(round == 2)
                                {
                                 RoundTwo();
                                }
                                else if(round == 3)
                                {
                                    restartRound();
                                }
            }
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
        public void RoundStart()
        {
            aRoundWinner = false;
            playersInGame = players;
            Round = 1;
        }
        public void RoundOne()
        {
            if (!aRoundWinner)
            {
                if (!everyoneTurnComplete())
                {
                    board.PlayerTurn(getCurrentPlayer().getPlayerNumber());
                }
                else
                {
                    foreach (Player p in playersInGame)
                    {
                        drawCard(p.getPlayerNumber(), 1);
                        board.showCard(p.getPlayerNumber(), 1);
                        p.turn = 0;
                    }
                    Round = 2;

                }
            }
            else
            {
                Round = 3;
            }

        }
        public void RoundTwo()
        {
            if (!aRoundWinner)
            {
                if (!everyoneTurnComplete())
                {
                    board.PlayerTurn(getCurrentPlayer().getPlayerNumber());
                }
                else {
                    foreach (Player p in playersInGame)
                    {
                        drawCard(p.getPlayerNumber(), 1);
                        board.showCard(p.getPlayerNumber(), 1);
                    }
                    Player winner = playersInGame[0];
                    foreach (Player p in playersInGame)
                    {
                        int value1 = p.card1.getValue() + p.card2.getValue();
                        if (value1 > (winner.card1.getValue() + winner.card2.getValue()))
                        {
                            winner = p;
                        }
                        else if (value1 == (winner.card1.getValue() + winner.card2.getValue()))
                        {
                            if (p.getState() == State.Winner && p != winner)
                            {
                                winner = p;
                            }
                            else if (p.getState() == State.Loser && winner.getState() == State.Neutral)
                            {
                                winner = p;
                            }
                            else
                            {
                                PlayerWonPot(winner, p);
                                break;
                            }

                        }
                    }
                    PlayerWonPot(winner);
                }
            }
            else
            {
                Round = 3;
            }
        }
        public void restartRound()
        {
            checkIfPlayerWon();
            SetWinnerLoser();
            board.ShowWinnerLoser();
            foreach(Player p in players)
            {
                p.allIn = 0;
                p.turn = 0;
                p.InRound = true;
            }
            pot = 0;
            callAmount = 0;
            //need to set no call amount in board
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
            else if(Round == 1)
            {
                next();
                RoundOne();
            }
            else if(Round == 2)
            {
                next();
                RoundTwo();
            }
            else if(Round == 3)
            {
                restartRound();
            }
            
        
        }
        private void next()
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
        public void PlayerWonPot(Player player)
        {
            aRoundWinner = true;
            if(player.allIn == 0)
            {
                player.chips += pot;
                DialogResult result = MessageBox.Show("Player: " + player.getPlayerName() + "Won :" + pot);
                if (result == DialogResult.OK)
                {
                    Round = 3;
                }
            }
            else
            {
                player.chips += player.allIn;
                pot -= player.allIn;
                Player winner = playersInGame[0];
                if(winner == player && playersInGame.Count > 1) { 
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
                winner.chips += pot;
                DialogResult result = MessageBox.Show("Player: " + player.getPlayerName() + "Won :" + player.allIn + " Player: " + winner.getPlayerName() + "Won " + pot);
                if (result == DialogResult.OK)
                {
                    Round = 3;
                }
            }
        }
        public void PlayerWonPot(Player player1, Player player2)
        {
            aRoundWinner = true;
                player1.chips += pot / 2;
                player2.chips += pot / 2;
            DialogResult result = MessageBox.Show("Players: " + player1.getPlayerName() + "   " + player2.getPlayerName() + "Won :" + pot / 2);
            if(result == DialogResult.OK)
            {
                Round = 3;
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
        public Player getWinner()
        {
            return WinningPlayer;
        }
    }
}
