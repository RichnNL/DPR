using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateApplication
{
    public partial class GameBoard : Form
    {
        private int numberofplayers;
        public int ChipsToWin;
        private bool gameStart;
        public Game game;
        public int numberOfPlayers
        {
            get { return numberofplayers; }
            set
            {
                numberofplayers = value;
                if(gameStart == false)
                {
                    game = new Game(numberOfPlayers,ChipsToWin,this);
                    gameStart = true;
                }
                if (numberofplayers == 0)
                {
                    initiateGame();
                }
            ;
            }
        }
        public GameBoard()
        {
            InitializeComponent();
            gameStart = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int bet = Convert.ToInt32(Player1betAmount.Value);
           
                if (game.callAmount == 0 && bet != 0)
                {
                    game.callAmount = bet;

                }
            if (game.callAmount != 0)
            {
                if (game.callAmount > game.getPlayer(1).getPlayerChips())
                {
                    game.pot += game.getPlayer(1).call(game.getPlayer(1).getPlayerChips());
                    game.getPlayer(1).allIn = game.pot;
                    game.getPlayer(1).InRound = false;
                    game.getPlayer(1).turn = 1;
                    game.ContinueRound();
                }
                else
                {
                    game.pot += game.getPlayer(1).call(game.callAmount);
                    game.getPlayer(1).turn = 1;
                    game.ContinueRound();

                }
                UpdateChips();
            }
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }
        public void playerOut(int player)
        {
            switch (player)
            {
                case 1:
                    Player1betAmount.Hide();
                    Player1CallButton.Hide();
                    Player1FoldButton.Hide();
                    Player1_name.Hide();
                    player1_money.Hide();
                    Player1Picture.Hide();
                    Player1Pb1.Hide();
                    Player1Pb2.Hide();
                    Player1Money_label.Hide();
                    break;
                case 2:
                    Player2BetAmount.Hide();
                    Player2CheckButton.Hide();
                    Player2FoldButton.Hide();
                    Player2Pb1.Hide();
                    Player2Pb2.Hide();
                    player2_money.Hide();
                    player2_money_label.Hide();
                    Player2RaiseButton.Hide();
                    Player2Picture.Hide();
                    break;
                case 3:
                    Player3BetAmount.Hide();
                    Player3CallButton.Hide();
                    Player3CheckButton.Hide();
                    Player3FoldButton.Hide();
                    Player3Pb1.Hide();
                    Player3Pb2.Hide();
                    Player3Picture.Hide();
                    Player3RaiseButton.Hide();
                    player3_money.Hide();
                    Player3_Name.Hide();
                    Player3Money_Label.Hide();
                    break;
                case 4:
                    Player4BetAmount.Hide();
                    Player4CallButton.Hide();
                    Player4CheckButton.Hide();
                    Player4FoldButton.Hide();
                    Player4Pb1.Hide();
                    Player4Pb2.Hide();
                    Player4Picture.Hide();
                    Player4RaiseButton.Hide();
                    Player4_money.Hide();
                    Player4Name_Label.Hide();
                    Player4MoneyLabel.Hide();
                    break;

            }
        }
        private void initiateGame()
        {
            this.Show();
            this.CenterToScreen();
            Player player = game.getPlayer(1);
            player1_money.Text = player.getPlayerChips().ToString();
            Player1_name.Text = player.getPlayerName();
            player = game.getPlayer(2);
            player2_money.Text = player.getPlayerChips().ToString();
            Player2_name.Text = player.getPlayerName();
            if (game.getNumberOfPlayers() == 2)
            {
                playerOut(3);
                playerOut(4);
               
            }
            else if(game.getNumberOfPlayers() == 3)
            {
                playerOut(4);
                player = game.getPlayer(3);
                player3_money.Text = player.getPlayerChips().ToString();
                Player3_Name.Text = player.getPlayerName();
            }
            else if(game.getNumberOfPlayers() == 4)
            {
                player = game.getPlayer(4);
                Player4_money.Text = player.getPlayerChips().ToString();
                Player4Name_Label.Text = player.getPlayerName();
            }
            game.Round = 0;
        }
        private void enablePlayer1()
        {
            Player1betAmount.Show();
            Player1CallButton.Enabled = true;
            if(game.getNumberPlayerTurns() > 1)
            {
                Player1CheckButton.Enabled = true;
            }
            if (game.callAmount > 0)
            {
                Player1FoldButton.Enabled = true;
                Player1RaiseButton.Enabled = true;
            }
            if (String.IsNullOrEmpty(textBoxPot.Text) || game.callAmount == 0)
            {
                Player1RaiseButton.Enabled = false;
                Player1CallButton.Text = "Place Bet";
            }
            else if(game.getPlayer(1).getPlayerChips() <= game.callAmount)
            {
                Player1CallButton.Text = "All In";
            }
            else
            {
                Player1CallButton.Text = "Call";
            }
        }
        private void disablePlayer1()
        {
            Player1betAmount.Hide();
            Player1CallButton.Enabled = false;
            Player1CheckButton.Enabled = false;
            Player1FoldButton.Enabled = false;
            Player1RaiseButton.Enabled = false;
          
        }
        private void enablePlayer2()
        {
            Player2BetAmount.Show();
            Player2CallButton.Enabled = true;
            if (game.getNumberPlayerTurns() > 1)
            {
                Player2CheckButton.Enabled = true;
            }
            if (game.callAmount > 0)
            {
                Player2FoldButton.Enabled = true;
                Player2RaiseButton.Enabled = true;
            }
            if (String.IsNullOrEmpty(textBoxPot.Text) || game.callAmount == 0)
            {
                Player2RaiseButton.Enabled = false;
                Player2CallButton.Text = "Place Bet";

            }
            else if (game.getPlayer(2).getPlayerChips() <= game.callAmount)
            {
                Player2CallButton.Text = "All In";
            }
            else
            {
                Player2CallButton.Text = "Call";
            }
        }
        private void disablePlayer2()
        {
            Player2BetAmount.Hide();
            Player2CallButton.Enabled = false;
            Player2CheckButton.Enabled = false;
            Player2FoldButton.Enabled = false;
            Player2RaiseButton.Enabled = false;
        }
        private void enablePlayer3()
        {
            Player3BetAmount.Show();
            Player3CallButton.Enabled = true;
            if (game.getNumberPlayerTurns() > 1)
            {
                Player3CheckButton.Enabled = true;
            }
            if (game.callAmount > 0)
            {
                Player3FoldButton.Enabled = true;
                Player3RaiseButton.Enabled = true;
            }
            if (String.IsNullOrEmpty(textBoxPot.Text) || game.callAmount == 0)
            {
                Player3RaiseButton.Enabled = false;
                Player3CallButton.Text = "Place Bet";
            }
            else if (game.getPlayer(3).getPlayerChips() <= game.callAmount)
            {
                Player3CallButton.Text = "All In";
            }
            else
            {
                Player3CallButton.Text = "Call";
            }
        }
        private void disablePlayer3()
        {
            Player3BetAmount.Hide();
            Player3CallButton.Enabled = false;
            Player3CheckButton.Enabled = false;
            Player3FoldButton.Enabled = false;
            Player3RaiseButton.Enabled = false;
        }
        private void enablePlayer4()
        {
            Player4BetAmount.Show();
            Player4CallButton.Enabled = true;
            if (game.getNumberPlayerTurns() > 1)
            {
                Player4CheckButton.Enabled = true;
            }
            if (game.callAmount > 0)
            {
                Player4FoldButton.Enabled = true;
                Player4RaiseButton.Enabled = true;
            }
            if (String.IsNullOrEmpty(textBoxPot.Text) || game.callAmount == 0)
            {
                Player4RaiseButton.Enabled = false;
                Player4CallButton.Text = "Place Bet";
            }
            else if (game.getPlayer(4).getPlayerChips() <= game.callAmount)
            {
                Player4CallButton.Text = "All In";
            }
            else
            {
                Player4CallButton.Text = "Call";
            }
        }
        private void disablePlayer4()
        {
            Player4BetAmount.Hide();
            Player4CallButton.Enabled = false;
            Player4CheckButton.Enabled = false;
            Player4FoldButton.Enabled = false;
            Player4RaiseButton.Enabled = false;
        }
        public void SetCall()
        {
            textboxCall.Text = game.callAmount.ToString();
        }
        public void SetPot()
        {
            textBoxPot.Text = game.pot.ToString();
        }
        public void addPlayer(string name, int chips)
        {
            game.addPlayer(new Player(name, chips, (game.getNumberOfPlayers() - numberOfPlayers) + 1));
        }

        public void PlayerTurn(int playerNumber)
        {
                disablePlayer1();
                disablePlayer2();
                disablePlayer3();
                disablePlayer4();
            switch (playerNumber)
            {
                case 1:
                    enablePlayer1();
                    break;
                case 2:
                    enablePlayer2();
                    break;
                case 3:
                    enablePlayer3();
                    break;
                case 4:
                    enablePlayer4();
                    break;
            }
                
            

            
        }
        public void ShowWinnerLoser()
        {
            int winner = game.getWinner().getPlayerNumber();
            int loser = game.getLoser().getPlayerNumber();
            switch (winner)
            {
                case 1:
                    Player1_name.ForeColor = System.Drawing.Color.CadetBlue;
                    Player1_name.Text = game.getWinner().getPlayerName() + "WINNING";
                    break;

                case 2:
                    Player2_name.ForeColor = System.Drawing.Color.CadetBlue;
                    Player2_name.Text = game.getWinner().getPlayerName() + "WINNING";
                    break;
                case 3:
                    Player3_Name.ForeColor = System.Drawing.Color.CadetBlue;
                    Player3_Name.Text = game.getWinner().getPlayerName() + "WINNING";
                    break;
                case 4:
                    Player4Name_Label.ForeColor = System.Drawing.Color.CadetBlue;
                    Player4Name_Label.Text = game.getWinner().getPlayerName() + "WINNING";
                    break;
            }
            switch (loser)
            {
                case 1:
                    Player1_name.ForeColor = System.Drawing.Color.Red;
                    Player1_name.Text = game.getLoser().getPlayerName() + "Losing";
                    break;

                case 2:
                    Player2_name.ForeColor = System.Drawing.Color.Red;
                    Player2_name.Text = game.getLoser().getPlayerName() + "Losing";
                    break;
                case 3:
                    Player3_Name.ForeColor = System.Drawing.Color.Red;
                    Player3_Name.Text = game.getLoser().getPlayerName() + "Losing";
                    break;
                case 4:
                    Player4Name_Label.ForeColor = System.Drawing.Color.Red;
                    Player4Name_Label.Text = game.getLoser().getPlayerName() + "Losing";
                    break;
            }

            for (int i = 1;i < game.getNumberOfPlayers(); i++)
            {
                if(i != game.getLoser().getPlayerNumber() && i != game.getWinner().getPlayerNumber())
                {
                    switch (i)
                    {
                        case 1:
                            Player1_name.ForeColor = System.Drawing.Color.Black;
                            Player1_name.Text = game.getPlayer(1).getPlayerName();
                            break;
                        case 2:
                            Player2_name.ForeColor = System.Drawing.Color.Black;
                            Player2_name.Text = game.getPlayer(2).getPlayerName();
                            break;
                        case 3:
                            Player3_Name.ForeColor = System.Drawing.Color.Black;
                            Player3_Name.Text = game.getPlayer(3).getPlayerName();
                            break;
                        case 4:
                            Player4Name_Label.ForeColor = System.Drawing.Color.Black;
                            Player4Name_Label.Text = game.getPlayer(4).getPlayerName();
                            break;
                    }
                }
            }
        }
       

        private void Player1betAmount_ValueChanged(object sender, EventArgs e)
        {
            Player1betAmount.Maximum = game.getPlayer(1).getPlayerChips();
        }

        private void Player2BetAmount_ValueChanged(object sender, EventArgs e)
        {
            Player2BetAmount.Maximum = game.getPlayer(2).getPlayerChips();
        }

        private void Player3BetAmount_ValueChanged(object sender, EventArgs e)
        {
            Player3BetAmount.Maximum = game.getPlayer(3).getPlayerChips();
        }

        private void Player4BetAmount_ValueChanged(object sender, EventArgs e)
        {
            Player4BetAmount.Maximum = game.getPlayer(4).getPlayerChips();
        }

        private void Player2CallButton_Click(object sender, EventArgs e)
        {
            int bet = Convert.ToInt32(Player2BetAmount.Value);
           
                if (game.callAmount == 0 && bet != 0)
                {
                    game.callAmount = bet;

                }
            if (game.callAmount != 0)
            {
                if (game.callAmount > game.getPlayer(2).getPlayerChips())
                {
                    game.pot += game.getPlayer(2).call(game.getPlayer(2).getPlayerChips());
                    game.getPlayer(2).allIn = game.pot;
                    game.getPlayer(2).InRound = false;
                    game.getPlayer(2).turn = 1;
                    game.ContinueRound();
                }
                else
                {
                    game.pot += game.getPlayer(2).call(game.callAmount);
                    game.getPlayer(2).turn = 1;
                    game.ContinueRound();

                }
                UpdateChips();
            }   
        }

        private void Player3CallButton_Click(object sender, EventArgs e)
        {
            int bet = Convert.ToInt32(Player3BetAmount.Value);
          


                if (game.callAmount == 0 && bet != 0)
                {
                    game.callAmount = bet;

                }
            if (game.callAmount != 0)
            {
                if (game.callAmount > game.getPlayer(3).getPlayerChips())
                {
                    game.pot += game.getPlayer(3).call(game.getPlayer(3).getPlayerChips());
                    game.getPlayer(3).allIn = game.pot;
                    game.getPlayer(3).InRound = false;
                    game.getPlayer(3).turn = 1;
                    game.ContinueRound();
                }
                else
                {
                    game.pot += game.getPlayer(3).call(game.callAmount);
                    game.getPlayer(3).turn = 1;
                    game.ContinueRound();

                }
                UpdateChips();
            }
        }

        private void Player4CallButton_Click(object sender, EventArgs e)
        {
            int bet = Convert.ToInt32(Player4BetAmount.Value);
           
                if (game.callAmount == 0 && bet != 0)
                {
                    game.callAmount = bet;

                }
            if (game.callAmount != 0)
            {
                if (game.callAmount > game.getPlayer(4).getPlayerChips())
                {
                    game.pot += game.getPlayer(4).call(game.getPlayer(4).getPlayerChips());
                    game.getPlayer(4).allIn = game.pot;
                    game.getPlayer(4).InRound = false;
                    game.getPlayer(4).turn = 1;
                    game.ContinueRound();
                }
                else
                {
                    game.pot += game.getPlayer(4).call(game.callAmount);
                    game.getPlayer(4).turn = 1;
                    game.ContinueRound();

                }
                UpdateChips();
            }
        }

        private void Player1FoldButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(1).turn = 1;
            game.getPlayer(1).fold(game.getLoser());
            game.playerOut(game.getPlayer(1));
            UpdateChips();
            game.ContinueRound();


        }
        public void showCard(int Player,int CardToShow)
        {
            if(CardToShow == 1)
            {
                switch (Player)
                {
                    case 1:
                        Player1Pb1.Image = game.getPlayer(1).card1.getImage();
                        break;
                    case 2:
                        Player2Pb1.Image = game.getPlayer(2).card1.getImage();
                        break;
                    case 3:
                        Player3Pb1.Image = game.getPlayer(3).card1.getImage();
                        break;
                    case 4:
                        Player4Pb1.Image = game.getPlayer(4).card1.getImage();
                        break;
                }
            }
            else if (CardToShow == 2)
            {
                switch (Player)
                {
                    case 1:
                        Player1Pb2.Image = game.getPlayer(1).card2.getImage();
                        break;
                    case 2:
                        Player2Pb2.Image = game.getPlayer(2).card2.getImage();
                        break;
                    case 3:
                        Player3Pb2.Image = game.getPlayer(3).card2.getImage();
                        break;
                    case 4:
                        Player4Pb2.Image = game.getPlayer(4).card2.getImage();
                        break;
                }
            }
            else
            {
                Player1Pb1.Image = null;
                Player1Pb2.Image = null;
                Player2Pb1.Image = null;
                Player2Pb2.Image = null;
                Player3Pb2.Image = null;
                Player3Pb1.Image = null;
                Player4Pb1.Image = null;
                Player4Pb2.Image = null;
            }

        }
        private void UpdateChips()
        {
            if(game.getPlayer(1) != null)
            {
                player1_money.Text = game.getPlayer(1).getPlayerChips().ToString();
                Player1betAmount.Value = 0;
            }
            if (game.getPlayer(2) != null)
            {
                player2_money.Text = game.getPlayer(2).getPlayerChips().ToString();
                Player2BetAmount.Value = 0;
            }
            if (game.getPlayer(3) != null)
            {
                player3_money.Text = game.getPlayer(3).getPlayerChips().ToString();
                Player3BetAmount.Value = 0;
            }
            if (game.getPlayer(4) != null)
            {
                Player4_money.Text = game.getPlayer(4).getPlayerChips().ToString();
                Player4BetAmount.Value = 0;
            }

        }

        private void Player2FoldButton_Click(object sender, EventArgs e)
        {

            game.getPlayer(2).turn = 1;
            game.getPlayer(2).InRound = false;
            game.getPlayer(2).fold(game.getLoser());
            game.playerOut(game.getPlayer(2));
            UpdateChips();
            game.ContinueRound();

        }

        private void Player3FoldButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(3).turn = 1;
            game.getPlayer(3).InRound = false;
            game.getPlayer(3).fold(game.getLoser());
            game.playerOut(game.getPlayer(3));
            UpdateChips();
            game.ContinueRound();

        }

        private void Player4FoldButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(4).turn = 1;
            game.getPlayer(4).InRound = false;
            game.getPlayer(4).fold(game.getLoser());
            game.playerOut(game.getPlayer(4));
            UpdateChips();
            game.ContinueRound();

        }

        private void Player1RaiseButton_Click(object sender, EventArgs e)
        {
            if(Player1betAmount.Value > game.callAmount)
            {
                int bet = Convert.ToInt32(Player1betAmount.Value);
                game.callAmount = bet;
                game.pot += game.getPlayer(1).raise(bet, game.getLoser());
                game.callRaised();
                game.getPlayer(1).turn = 1;
                UpdateChips();
                game.ContinueRound();

            }
        }

        private void Player2RaiseButton_Click(object sender, EventArgs e)
        {
            if (Player2BetAmount.Value > game.callAmount)
            {
                int bet = Convert.ToInt32(Player2BetAmount.Value);
                game.callAmount = bet;
                game.pot += game.getPlayer(2).raise(bet, game.getLoser());
                game.callRaised();
                game.getPlayer(2).turn = 1;
                UpdateChips();
                game.ContinueRound();

            }
        }

        private void Player3RaiseButton_Click(object sender, EventArgs e)
        {
            if (Player3BetAmount.Value > game.callAmount)
            {
                int bet = Convert.ToInt32(Player3BetAmount.Value);
                game.callAmount = bet;
                game.pot += game.getPlayer(3).raise(bet, game.getLoser());
                game.callRaised();
                game.getPlayer(3).turn = 1;
                UpdateChips();
                game.ContinueRound();

            }
        }

        private void Player4RaiseButton_Click(object sender, EventArgs e)
        {
            if (Player4BetAmount.Value > game.callAmount)
            {
                int bet = Convert.ToInt32(Player4BetAmount.Value);
                game.callAmount = bet;
               
                game.pot += game.getPlayer(4).raise(bet, game.getLoser());
                game.callRaised();
                game.getPlayer(4).turn = 1;
                UpdateChips();
                game.ContinueRound();

            }
        }

        private void Player1CheckButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(1).check(game.getLoser());
            UpdateChips();
            game.CurrentPlayersTurn++;
            game.ContinueRound();

        }

        private void Player2CheckButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(2).check(game.getLoser());
            UpdateChips();
            game.CurrentPlayersTurn++;
            game.ContinueRound();

        }

        private void Player3CheckButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(3).check(game.getLoser());
            UpdateChips();
            game.CurrentPlayersTurn++;
            game.ContinueRound();

        }

        private void Player4CheckButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(4).check(game.getLoser());
            UpdateChips();
            game.CurrentPlayersTurn++;
            game.ContinueRound();

        }
    }
}
