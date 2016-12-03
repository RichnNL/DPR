using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMW_Car_Dealership
{
    public partial class Form1 : Form
    {
        TankosDealership bmws;
        public Form1()
        {
            InitializeComponent();
            bmws = new TankosDealership();
            addBMWStoList(bmws.stock);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BMW_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = BMW_Selection.SelectedItem.ToString();
            selected(sec, bmws.stock);
            DisplayImage(sec);

        }
        private void addBMWStoList(List<BMW> list)
        {
            foreach(var b in list)
            {
                BMW_Selection.Items.Add(b.getImage());
            }
        }
        private void selected(String bmw, List<BMW> bmws)
        {
            Accessories.Items.Clear();
            BMW b;
            foreach(var car in bmws)
            {
                if(bmw == car.getImage())
                {
                    b = car;
                    foreach (var v in b.getPossibleAccessories())
                    {
                        Accessories.Items.Add(v);
                    }
                }
            }
           
        }
        private void DisplayImage(String image)
        {
            switch (image)
            {
                case "I8" :
                    pictureBox1.Image = BMW_Car_Dealership.Properties.Resources.I8;
                    break;
                case "CarbonBrakes":
                    pictureBox1.Image = BMW_Car_Dealership.Properties.Resources.CarbonBrakes;
                    break;
                case "loudspeakers":
                    pictureBox1.Image = BMW_Car_Dealership.Properties.Resources.loudspeakers;
                    break;
                case "m6coupe":
                    pictureBox1.Image = BMW_Car_Dealership.Properties.Resources.m6coupe;
                    break;
                case "ParkAssist":
                    pictureBox1.Image = BMW_Car_Dealership.Properties.Resources.ParkAssist;
                    break;
                case "z4":
                    pictureBox1.Image = BMW_Car_Dealership.Properties.Resources.z4;
                    break;
                case "2SeriesCoupe":
                    pictureBox1.Image = BMW_Car_Dealership.Properties.Resources._2SeriesCoupe;
                    break;
                case "7Series":
                    pictureBox1.Image = BMW_Car_Dealership.Properties.Resources._7Series;
                    break;
            }
        
            
        }


        private void Accessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = Accessories.SelectedItem.ToString();
            DisplayImage(sec);
        }
    }
}
