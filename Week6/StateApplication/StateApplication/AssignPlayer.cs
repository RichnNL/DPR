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
    public partial class AssignPlayer : Form
    {
        string playerName;
        int money;
        GameBoard gameboard;
        public AssignPlayer(GameBoard game)
        {
            InitializeComponent();
            this.gameboard = game;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            playerName = textBox1.Text;
        }

        private void player1bet_ValueChanged(object sender, EventArgs e)
        {
            money = Convert.ToInt32( player1bet.Value);
        }

        private void Set_Button_Click(object sender, EventArgs e)
        {
            if(money > 50 && playerName.Length > 2)
            {
                gameboard.addPlayer(playerName,money);
                gameboard.numberOfPlayers--;
                this.Close();
            }
        }

        private void AssignPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
