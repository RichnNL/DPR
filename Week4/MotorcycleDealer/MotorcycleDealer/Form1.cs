using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleDealer
{
    public partial class Form1 : Form
    {
        TsankosMotorCycleDealship Motorcycledealership;
        private string type;
        private string model;
        public Form1()
        {

            InitializeComponent();
            Motorcycledealership = new TsankosMotorCycleDealship();
            fillType(Motorcycledealership);
        

        }

        private void listbox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            setType(listbox_type.SelectedItem.ToString());
            fillModel(Motorcycledealership, type);
        }
        private void fillType(TsankosMotorCycleDealship dealer)
        {
            foreach(List<string> model in dealer.type)
            {
                listbox_type.Items.Add(model[0]);
            }
        }
        private void fillModel(TsankosMotorCycleDealship dealer, string type)
        {
            listbox_model.Items.Clear();
            foreach (List<string> model in dealer.type)
            {
                if(model[0] == type)
                {
                    for(int i = 1; i < model.Count; i++)
                    {
                        listbox_model.Items.Add(model[i]);
                    }
                }
               
            }
        }
        private void setType(string Type)
        {
            this.type = Type;
        }
        private void setModel(string Model)
        {
            this.model = Model;
        }

        private void listbox_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            setModel(listbox_model.SelectedItem.ToString());
            Motorcycle motorcycle = Motorcycledealership.dealer.orderMotorcycle(type, model);
            if(motorcycle != null)
            {
                displayMotorCycle(motorcycle,model);
            }
            
        }
        private void displayMotorCycle(Motorcycle motorcycle, string name)
        {
            pictureBox1.Image = motorcycle.getImage();
            label_description.Text = "The " + name + motorcycle.ToString();
            label_price.Text = motorcycle.getPrice().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
