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
            if (game.callAmount == 0)
            {
                    game.callAmount = bet;
                textboxCall.Text = bet.ToString();
            }
            if(game.callAmount > game.getPlayer(1).getPlayerChips())
            {
                game.pot += game.getPlayer(1).call(game.getPlayer(1).getPlayerChips());
                game.getPlayer(1).allIn = game.pot;
                game.getPlayer(1).InRound = false;
                game.getPlayer(1).turn = 1;
            }
            else
            {
                game.pot += game.getPlayer(1).call(game.callAmount);
                textBoxPot.Text = game.pot.ToString();
                game.getPlayer(1).turn = 1;
                game.setNextPlayer();
                PlayerTurn(game.CurrentPlayersTurn);
            }
            UpdateChips();
        
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

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
                Player3BetAmount.Hide();
                Player3CallButton.Hide();
                Player3CheckButton.Hide();
                Player3FoldButton.Hide();
                Player3Pb1.Hide();
                Player3Pb2.Hide();
                Player3Picture.Hide();
                Player3RaiseButton.Hide();
                Player3RaiseButton.Hide();
                player3_money.Hide();
                Player3_Name.Hide();
                Player3Money_Label.Hide();
                Player3BetAmount.Hide();
                Player4BetAmount.Hide();
                Player4CallButton.Hide();
                Player4CheckButton.Hide();
                Player4FoldButton.Hide();
                Player4Pb1.Hide();
                Player4Pb2.Hide();
                Player4Picture.Hide();
                Player4RaiseButton.Hide();
                Player4_money.Hide();
                Player4BetAmount.Hide();
                Player4Name_Label.Hide();
                Player4MoneyLabel.Hide();
            }
            else if(game.getNumberOfPlayers() == 3)
            {
                Player4BetAmount.Hide();
                Player4CallButton.Hide();
                Player4CheckButton.Hide();
                Player4FoldButton.Hide();
                Player4Pb1.Hide();
                Player4Pb2.Hide();
                Player4Picture.Hide();
                Player4RaiseButton.Hide();
                Player4_money.Hide();
                Player4BetAmount.Hide();
                Player4Name_Label.Hide();
                Player4MoneyLabel.Hide();
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
        }
        private void enablePlayer1()
        {
            Player1betAmount.Show();
            Player1CallButton.Enabled = true;
            Player1CheckButton.Enabled = true;
            Player1FoldButton.Enabled = true;
            Player1RaiseButton.Enabled = true;
            if (String.IsNullOrEmpty(textBoxPot.Text))
            {
                Player1RaiseButton.Enabled = false;
                Player1CallButton.Text = "Place Bet";
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
            Player2CheckButton.Enabled = true;
            Player2FoldButton.Enabled = true;
            Player2RaiseButton.Enabled = true;
            if (String.IsNullOrEmpty(textBoxPot.Text))
            {
                Player2RaiseButton.Enabled = false;
                Player2CallButton.Text = "Place Bet";
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
            Player3CheckButton.Enabled = true;
            Player3FoldButton.Enabled = true;
            Player3RaiseButton.Enabled = true;
            if (String.IsNullOrEmpty(textBoxPot.Text))
            {
                Player3RaiseButton.Enabled = false;
                Player3CallButton.Text = "Place Bet";
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
            Player4CheckButton.Enabled = true;
            Player4FoldButton.Enabled = true;
            Player4RaiseButton.Enabled = true;
            if (String.IsNullOrEmpty(textBoxPot.Text))
            {
                Player4RaiseButton.Enabled = false;
                Player4CallButton.Text = "Place Bet";
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
            if (game.callAmount == 0)
            {
                game.callAmount = bet;
                textboxCall.Text = bet.ToString();
            }
            if (game.callAmount > game.getPlayer(1).getPlayerChips())
            {
                game.pot += game.getPlayer(2).call(game.getPlayer(2).getPlayerChips());
                game.getPlayer(2).allIn = game.pot;
                game.getPlayer(2).InRound = false;
                game.getPlayer(2).turn = 1;
            }
            else
            {
                game.pot += game.getPlayer(2).call(game.callAmount);
                textBoxPot.Text = game.pot.ToString();
                game.getPlayer(2).turn = 1;
                game.setNextPlayer();
                PlayerTurn(game.CurrentPlayersTurn);
            }
            UpdateChips();
        }

        private void Player3CallButton_Click(object sender, EventArgs e)
        {
            int bet = Convert.ToInt32(Player3BetAmount.Value);
            if (game.callAmount == 0)
            {
                game.callAmount = bet;
                textboxCall.Text = bet.ToString();
            }
            if (game.callAmount > game.getPlayer(3).getPlayerChips())
            {
                game.pot += game.getPlayer(3).call(game.getPlayer(3).getPlayerChips());
                game.getPlayer(3).allIn = game.pot;
                game.getPlayer(3).InRound = false;
                game.getPlayer(3).turn = 1;
            }
            else
            {
                game.pot += game.getPlayer(3).call(game.callAmount);
                textBoxPot.Text = game.pot.ToString();
                game.getPlayer(3).turn = 1;
                game.setNextPlayer();
                PlayerTurn(game.CurrentPlayersTurn);
            }
            UpdateChips();
        }

        private void Player4CallButton_Click(object sender, EventArgs e)
        {
            int bet = Convert.ToInt32(Player4BetAmount.Value);
            if (game.callAmount == 0)
            {
                game.callAmount = bet;
                textboxCall.Text = bet.ToString();
            }
            if (game.callAmount > game.getPlayer(4).getPlayerChips())
            {
                game.pot += game.getPlayer(4).call(game.getPlayer(4).getPlayerChips());
                game.getPlayer(4).allIn = game.pot;
                game.getPlayer(4).InRound = false;
                game.getPlayer(4).turn = 1;
            }
            else
            {
                game.pot += game.getPlayer(4).call(game.callAmount);
                textBoxPot.Text = game.pot.ToString();
                game.getPlayer(4).turn = 1;
                game.setNextPlayer();
                PlayerTurn(game.CurrentPlayersTurn);
            }
            UpdateChips();
        }

        private void Player1FoldButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(1).turn = 1;
            game.playerOut(game.getPlayer(1));
            game.getPlayer(1).fold(game.getLoser());
            UpdateChips();
            game.setNextPlayer();
            PlayerTurn(game.CurrentPlayersTurn);

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
                Player3Pb2.Image = null;
                Player3Pb1.Image = null;
                Player4Pb2.Image = null;
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
            game.playerOut(game.getPlayer(2));
            game.getPlayer(2).fold(game.getLoser());
            UpdateChips();
            game.setNextPlayer();
            PlayerTurn(game.CurrentPlayersTurn);
        }

        private void Player3FoldButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(3).turn = 1;
            game.getPlayer(3).InRound = false;
            game.playerOut(game.getPlayer(3));
            game.getPlayer(3).fold(game.getLoser());
            UpdateChips();
            game.setNextPlayer();
            PlayerTurn(game.CurrentPlayersTurn);
        }

        private void Player4FoldButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(4).turn = 1;
            game.getPlayer(4).InRound = false;
            game.playerOut(game.getPlayer(4));
            game.getPlayer(4).fold(game.getLoser());
            UpdateChips();
            game.setNextPlayer();
            PlayerTurn(game.CurrentPlayersTurn);
        }

        private void Player1RaiseButton_Click(object sender, EventArgs e)
        {
            if(Player1betAmount.Value > game.callAmount)
            {
                int bet = Convert.ToInt32(Player1betAmount.Value);
                game.callAmount = bet;
                textboxCall.Text = bet.ToString();
                game.pot += game.getPlayer(1).raise(bet, game.getLoser());
                game.getPlayer(1).turn = 1;
                game.setNextPlayer();
                PlayerTurn(game.CurrentPlayersTurn);
            }
        }

        private void Player2RaiseButton_Click(object sender, EventArgs e)
        {
            if (Player2BetAmount.Value > game.callAmount)
            {
                int bet = Convert.ToInt32(Player2BetAmount.Value);
                game.callAmount = bet;
                textboxCall.Text = bet.ToString();
                game.pot += game.getPlayer(2).raise(bet, game.getLoser());
                game.getPlayer(2).turn = 1;
                game.setNextPlayer();
                PlayerTurn(game.CurrentPlayersTurn);
            }
        }

        private void Player3RaiseButton_Click(object sender, EventArgs e)
        {
            if (Player3BetAmount.Value > game.callAmount)
            {
                int bet = Convert.ToInt32(Player3BetAmount.Value);
                game.callAmount = bet;
                textboxCall.Text = bet.ToString();
                game.pot += game.getPlayer(3).raise(bet, game.getLoser());
                game.getPlayer(3).turn = 1;
                game.setNextPlayer();
                PlayerTurn(game.CurrentPlayersTurn);
            }
        }

        private void Player4RaiseButton_Click(object sender, EventArgs e)
        {
            if (Player4BetAmount.Value > game.callAmount)
            {
                int bet = Convert.ToInt32(Player4BetAmount.Value);
                game.callAmount = bet;
                textboxCall.Text = bet.ToString();
                game.pot += game.getPlayer(4).raise(bet, game.getLoser());
                game.getPlayer(4).turn = 1;
                game.setNextPlayer();
                PlayerTurn(game.CurrentPlayersTurn);
            }
        }

        private void Player1CheckButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(1).check(game.getLoser());
            game.setNextPlayer();
            PlayerTurn(game.CurrentPlayersTurn);
        }

        private void Player2CheckButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(2).check(game.getLoser());
            game.setNextPlayer();
            PlayerTurn(game.CurrentPlayersTurn);
        }

        private void Player3CheckButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(3).check(game.getLoser());
            game.setNextPlayer();
            PlayerTurn(game.CurrentPlayersTurn);
        }

        private void Player4CheckButton_Click(object sender, EventArgs e)
        {
            game.getPlayer(4).check(game.getLoser());
            game.setNextPlayer();
            PlayerTurn(game.CurrentPlayersTurn);
        }
    }
}
