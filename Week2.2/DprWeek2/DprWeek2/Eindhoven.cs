using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DprWeek2
{
    public partial class Eindhoven : Form, IObserver
    {
        int temperature;
        bool chance;

        public Eindhoven(int temp, bool isItraining)
        {
            InitializeComponent();
            temperature = temp;
            chance = isItraining;
        }


        //public void update();  // bool isRaining, int temprature)
        //{
        //    textBox1.Text = Convert.ToString(temprature) + " C";
        //    if (isRaining)
        //    {
        //        label2.Text = "It is raining";
        //    }
        //    else
        //    {
        //        label2.Text = "It is not raining";
        //    }
        //}

        private void Eindhoven_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void update()
        {
            textBox1.Text = Convert.ToString(temperature);
        }
    }
}
