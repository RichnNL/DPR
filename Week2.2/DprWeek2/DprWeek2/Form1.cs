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
    public partial class Form1 : Form
    {
        WeatherPrediction weather;
        public Form1()
        {
            InitializeComponent();
            weather = new WeatherPrediction();
            IObserver City = new CurrentLocation(weather.Temperature, weather.CalculateRain());
            IObserver Eindhoven = new Eindhoven(weather.Temperature, weather.CalculateRain());
            weather.Attach(City);
            ((Form)City).Show();

            weather.Attach(Eindhoven);
            ((Form)Eindhoven).Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            weather.Changer(Convert.ToInt32(textBox1.Text));
            weather.Notify();
        }
    }
}
