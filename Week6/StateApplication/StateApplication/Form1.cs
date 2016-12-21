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
    public partial class Form1 : Form
    {
        int numberOfPlayers;
        int ChipstoWin;
        public Form1()
        {
            InitializeComponent();
            numberOfPlayers = 2;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numberOfPlayers = Convert.ToInt32(numericUpDown1.Value);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.Parent = this;
            gameBoard.numberOfPlayers = numberOfPlayers;
            gameBoard.ChipsToWin = ChipstoWin;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                AssignPlayer assignplayer = new AssignPlayer(gameBoard);
                assignplayer.Show();
            }
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ChipstoWin = Convert.ToInt32(numericUpDown2.Value);
        }
    }
}
