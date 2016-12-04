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
        string selectedcar;
        public Form1()
        {
            InitializeComponent();
            bmws = new TankosDealership();
            addBMWStoList(bmws.stock);
            selectedcar = "";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BMW_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedcar = BMW_Selection.SelectedItem.ToString();
            selected(selectedcar, bmws.stock);
            DisplayImage(selectedcar);
            displayDesciption(selectedcar, bmws.stock);
            BMW b = getBmw(selectedcar, bmws.stock);
            showBMWAccessory(b);
            displayPrice(b);

        }
        private void addBMWStoList(List<BMW> list)
        {
            foreach (var b in list)
            {
                BMW_Selection.Items.Add(b.getImage());
            }
        }
        private void selected(string bmw, List<BMW> bmws)
        {
            Accessories.Items.Clear();
            BMW b = getBmw(bmw, bmws);
            foreach (var v in b.getPossibleAccessories())
            {
                Accessories.Items.Add(v);
            }

        }
        private void showBMWAccessory(BMW bmw)
        {
            Accessories.Items.Clear();
            foreach (var v in bmw.getPossibleAccessories())
            { 
                Accessories.Items.Add(v);
            }
        }
        private void DisplayImage(String image)
        {
            switch (image)
            {
                case "I8":
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
                case "2Series":
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
            showDescriptionAccessory(sec);
            BMW b = getBmw(selectedcar, bmws.stock);
            
                foreach (var v in Accessories.CheckedItems)
                {
                    string access = v.ToString();
                    b = addAccessories(b, access);

                }
                displayPrice(b);
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void displayDesciption(string bmw, List<BMW> bmws)
        {
            BMW b = getBmw(bmw, bmws);
            string desciption = "Description " + b.getDescription();
            if(desciption.Length < 20)
            {
                label_description.Font = new Font(label_description.Font.FontFamily, 10);
            }
            else if(desciption.Length > 20)
            {
                label_description.Font = new Font(label_description.Font.FontFamily, 6);
                label_description.MaximumSize = new Size(200,300);       
            }
            label_description.Text = desciption;
        }
        private void displayPrice(BMW bmw)
        {
            label_price.Text = "€ " + bmw.getPrice().ToString();
        }
        private BMW getBmw(string bmw, List<BMW> bmws)
        {
            
            BMW b;
            foreach (var car in bmws)
            {
                if (bmw == car.getImage())
                {
                    b = car;
                    return b;
                }
            }
            return null;
            
        }
        private BMW addAccessories(BMW bmw, string Accessory)
        {
            BMW_Car_Dealership.Accessories temp;
            switch (Accessory)
            {
                case "CarbonBrakes":
                temp = new Carbon_Brakes(bmw);
                    break;
                case "loudspeakers":
                temp = new BMWLoudSpeakerSystem(bmw);
                    break;
                case "ParkAssist":
                    temp = new ParkAssist(bmw);
                    break;
                default:
                    temp = (Accessories)bmw;
                    break;
            }
            return temp;
        }
        private void showDescriptionAccessory(string accessory)
        {
            BMW_Car_Dealership.Accessories temp;
            switch (accessory)
            {
                case "CarbonBrakes":
                    temp = new Carbon_Brakes(null);
                    break;
                case "loudspeakers":
                    temp = new BMWLoudSpeakerSystem(null);
                    break;
                case "ParkAssist":
                    temp = new ParkAssist(null);
                    break;
                default:
                    return;
                    break;
            }
            label_description.Text = temp.getDescription();
            
        }
      
       
    }
}
