using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Songs
{
    public partial class Form1 : Form
    {
        SongArray70s songs70s;
        Song80sArray songs80s;
        ICustomIterator iterator;
        public Form1()
        {
            InitializeComponent();
           
            songs70s = new SongArray70s();
            songs70s.Add(new Songs("I fell love", "Donna Summer", 1975));
            songs70s.Add(new Songs("The Ramones", "Blitzkrieg Bop", 1972));
            songs70s.Add(new Songs("David Bowie", "Heroes", 1974));
            songs70s.Add(new Songs("The clash", "London Calling", 1973));
            songs70s.Add(new Songs("MIchael Jackson", "Don't stop", 1979));

            // iterator = songs70s.CreateIterator();

            songs80s = new Song80sArray();
            songs80s.Add(new Songs("Bon Jovi", "Livin on Prayer", 1982));
            songs80s.Add(new Songs("Hungry like the wolf", " Duran Duran", 1987));
            songs80s.Add(new Songs("Michael Jackson", "Billie Jean", 1981));
            songs80s.Add(new Songs("Madddona", "Like a virgin", 1984));
            //   iterator = songs80s.CreateIterator();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            iterator = songs70s.CreateIterator();
            while (iterator.HasNext())
            {
                Songs item = (Songs)iterator.Next();
                listBox1.Items.Add(item.Name);
                listBox2.Items.Add(item.Band);
                listBox3.Items.Add(item.Year.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            iterator = songs80s.CreateIterator();
            while (iterator.HasNext())
            {
                Songs item = (Songs)iterator.Next();
                listBox1.Items.Add(item.Name);
                listBox2.Items.Add(item.Band);
                listBox3.Items.Add(item.Year.ToString());
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
