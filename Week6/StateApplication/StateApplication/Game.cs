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
        private int Pot;
        public int pot { get { return Pot; }
            set { Pot = value; board.SetPot(); } }
        private int callamount;
        public int callAmount
        {
            get { return callamount; }
            set { callamount = value; board.SetCall(); }
        }
        List<Player> players;
        List<Player> playersInGame;
        Player WinningPlayer;
        Player LosingPlayer;
        Deck deck;
        private int playersTurn;
        private int round;
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
            set { if(value > players.Count)
                {
                    playersTurn = 1;
                }
            else if(value < 1)
                {
                    playersTurn = playersInGame.Count;
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
            players = new List<Player>();
            playersInGame = new List<Player>(players);
            this.board = gameboard;
            CurrentPlayersTurn = 1;
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
            bool currentPlayerOK = false;
            if(getNumberPlayerTurns() != 0)
            {
                while (!currentPlayerOK)
                {
                    if (players[CurrentPlayersTurn - 1].allIn == 0 && players[CurrentPlayersTurn - 1].InRound == true && players[CurrentPlayersTurn - 1].turn == 0)
                    {
                        currentPlayerOK = true;
                        return players[CurrentPlayersTurn - 1];
                    }
                    CurrentPlayersTurn++;
                }
                return null;
            }
            else
            {
                return null;
            }

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
        
        public void RoundStart()
        {
            SetWinnerLoser();
            CurrentPlayersTurn = 1;
            board.ShowWinnerLoser();
            playersInGame.Clear();
            playersInGame = players.ToList();
            Round = 1;
            if (WinningPlayer != null)
            {
                int bonus = (WinningPlayer.getPlayerChips() * 1) / 100;
                WinningPlayer.chips += bonus;
            }
            
        }
        public void RoundOne()
        {
                if (getCurrentPlayer() != null)
                {
                    board.PlayerTurn(getCurrentPlayer().getPlayerNumber());
                }
                else
                {   //Everyone else folded
                    if (playersInGame.Count == 1)
                    {
                        PlayerWonPot(playersInGame[0]);
                    }
                    else if(!enoughPlayersForNextRound())
                     {
                        //everyone is all in or folded
                        foreach (Player p in playersInGame)
                        {        //Prepare Players for next round
                            drawCard(p.getPlayerNumber(), 1);
                            board.showCard(p.getPlayerNumber(), 1);
                            p.turn = 1;
                        }
                        Round = 2;
                }
                    else
                    { 
                    foreach (Player p in playersInGame)
                    {   //Prepare Players for next round
                        drawCard(p.getPlayerNumber(), 1);
                        board.showCard(p.getPlayerNumber(), 1);
                        p.turn = 0;
                        p.amountCalled = 0;
                    }
                    //Preparegame for next round
                    CurrentPlayersTurn = 1;
                    callAmount = 0;
                    Round = 2;

                }
            }
        }
        public void RoundTwo()
        {
                if (getCurrentPlayer() != null )
                {
                    board.PlayerTurn(getCurrentPlayer().getPlayerNumber());
                }
                else
                {
                if(playersInGame.Count == 1)
                {
                    PlayerWonPot(playersInGame[0]);
                }
                else
                { 
                    foreach (Player p in playersInGame)
                    {
                        drawCard(p.getPlayerNumber(), 2);
                        board.showCard(p.getPlayerNumber(), 2);
                    }
                    Player winner = findWinner();
                    if (checkForTies(winner))
                    {
                        Player tiedPlayer = getTiedPlayer(winner);
                        PlayerWonPot(winner, tiedPlayer);
                    }
                    else
                    {    
                    PlayerWonPot(winner);
                    }

                }
            }
        }
        public void restartRound()
        {
            checkIfPlayerWon();
            resetPlayers();
            SetWinnerLoser();
            nextPlayerOrder();
            pot = 0;
            callAmount = 0;
            deck.shuffle();
            Round = 0;
        }
        private void resetPlayers()
        {
            foreach (Player p in players)
            {
                p.allIn = 0;
                p.turn = 0;
                p.InRound = true;
                p.amountCalled = 0;
                p.card1 = null;
                p.card2 = null;
                board.showCard(p.getPlayerNumber(), 0);
            }
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
            else if(LosingPlayer.getPlayerChips() > TempLosing.getPlayerChips())
            {
                LosingPlayer = TempLosing;
                LosingPlayer.setPlayerState(State.Loser);
            }
            foreach(Player p in players)
            {
                if(p.getPlayerName() != WinningPlayer.getPlayerName() && p.getPlayerName() != LosingPlayer.getPlayerName())
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
        public void ContinueRound()
        {
            if(playersInGame.Count == 1)
            {
                PlayerWonPot(playersInGame[0]);
            }
            else if(Round == 1)
            {
                RoundOne();    
            }
            else if(Round == 2)
            {
                 RoundTwo();  
            }
            else if(Round == 3)
            {
                restartRound();
            }
        }
        
       
        private int numberPlayersInRound()
        {
            int number = 0;
            foreach(Player p in playersInGame)
            {
                if(p.allIn == 0 && p.turn == 0 && p.InRound)
                {
                    number++;
                }
            }
            return number;
        }
        public void PlayerWonPot(Player player)
        {
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
                    if(p != player && p != winner)
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
           if(players.Count == 1)
            {
                DialogResult result = MessageBox.Show("Player:" + players[0] + "has won the game with " + players[0].getPlayerChips() + "chips");
                if (result == DialogResult.OK)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    board.Close();
                    return true;
                }
            
                else
                {
                    board.Close();
                }
            }
            List<int> PlayersLost = new List<int>();
            foreach(Player p in players)
            {
                if(p.getPlayerChips() >= ChipsToWin)
                {
                  DialogResult result =  MessageBox.Show("Player:" + p.getPlayerName() + "has won the game with " + p.getPlayerChips() + "chips" + "Press ok to play again");
                    if(result == DialogResult.OK)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
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
                    DialogResult result = MessageBox.Show("Player: " + p.getPlayerName() + "Lost");
                    board.playerOut(p.getPlayerNumber());
                    PlayersLost.Add(p.getPlayerNumber());
                    
                    
                }
            }
            if(PlayersLost.Count != 0)
            {
                foreach(int i in PlayersLost)
                {
                    numberofplayers--;
                    players.Remove(getPlayer(i));
                    SetWinnerLoser();
                }
            }
            return false;
        }
        public Player getWinner()
        {
            return WinningPlayer;
        }
        public int getNumberPlayerTurns()
        {
            int number = 0;
            foreach(Player p in playersInGame)
            {
                if(p.turn == 0)
                {
                    number++;
                }
            }
            return number;
        }
        public void callRaised()
        {
            foreach(Player p in playersInGame)
            {
                if (p.InRound && p.allIn == 0)
                {
                    p.turn = 0;
                }
            }
        }
        
        private Player findWinner()
        {
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
                }
                
            }
            return winner;
        }
        private bool checkForTies(Player winner)
        {
            int WinningValue = winner.card1.getValue() + winner.card2.getValue();
            foreach (Player p in playersInGame)
            {
                int Othervalue = p.card1.getValue() + p.card2.getValue();
                if(Othervalue == WinningValue && winner.getState() != State.Winner && (p.getState() != State.Neutral && winner.getState() != State.Loser ))
                {
                    return true;
                }
            }
            return false;
        }
        private Player getTiedPlayer(Player winner)
        {
            int WinningValue = winner.card1.getValue() + winner.card2.getValue();
            foreach (Player p in playersInGame)
            {
                int Othervalue = p.card1.getValue() + p.card2.getValue();
                if (Othervalue == WinningValue && winner.getState() != State.Winner && (p.getState() != State.Neutral && winner.getState() != State.Loser))
                {
                    return p;
                }
            }
            return null;
        }
        private void previous()
        {
            if (playersInGame.Count != 0)
            {
                for (int i = 1; i < playersInGame.Count; i++)
                {
                    CurrentPlayersTurn--;
                    if (getCurrentPlayer().turn == 0 && getCurrentPlayer().allIn == 0 && getCurrentPlayer().InRound)
                    {
                        break;
                    }
                }
            }
        }
        private bool enoughPlayersForNextRound()
        {
            int number = 0;
            foreach (Player p in playersInGame)
            {
                if (p.allIn == 0 && p.InRound)
                {
                    number++;
                }
            }
            if(number > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
       
    }
}
