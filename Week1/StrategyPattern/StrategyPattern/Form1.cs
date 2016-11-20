using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        Process process;
        PreEmptive pre;
        Non_pre non;
        FCFS fcfs;
        string Naam;
        int BurstTime;
        int arrival;
        List<int> totalarrival;
        int paused; //-1 start from beginning 0 paused 1 is complete
        List<string[]> data = new List<string[]>();
        List<string[]> processedData = new List<string[]>();
        //Progress Bar Position 0 = current process, 1 = current position in process, 2 = total completion 
        int[] pos = { 0, 0, 0 };
        readonly int y;
        int x = 0;
        readonly int width;
        public Form1()
        {
            InitializeComponent();
            pre = new PreEmptive();
            non = new Non_pre();
            fcfs = new FCFS();
            arrival = 0;
            totalarrival = new List<int>();
            y = 0;
            width = panel1.Width;
            paused = -1;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
           
            this.MaximizeBox = false;
           
            this.MinimizeBox = false;
            
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                process = null;
                process = new FirstCome(fcfs);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                process = null;
                process = new Shortest(non);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adds the process to the list
            paused = -1;
            restartBar();
            addProcess();
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processData();
            if (processedData.Count != 0)
            {
                Thread thread;
                if (paused == -1)
                {
                    restartBar();
                    thread = new Thread(processBarStart);
                    paused = 1;
                    thread.Start();
                }
                else if (paused == 0)
                {
                    thread = new Thread(processBarStart);
                    paused = 1;
                    thread.Start();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool found = false;
            int a = 0;
            for(int i = 0; i < data.Count; i++)
            {
                string search = data[i][0] + "," + " BT: " + data[i][1] + ",AT: " + data[i][2];
                if (search.Equals(checkedListBox1.SelectedItem.ToString()))
                {
                    a = Convert.ToInt32(data[i][2]);
                    data.Remove(data[i]);
                    totalarrival.Remove(a);
                    found = true;
                    cal_arrivaltime();
                }
               
            }
            if (found)
            {
                
                checkedListBox1.Items.Clear();
                for(int i = 0; i< data.Count; i++)
                {
             
                    checkedListBox1.Items.Add(data[i][0] + "," + " BT: " + data[i][1] + ",AT: " + data[i][2]);
                }
            }
            }
        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private string getColor()
        {
            string colour = "red";
            if (rb_color_blue.Checked)
            {
                colour = "blue";
            }
            else if (rb_color_green.Checked)
            {
                colour = "green";
            }
            else if (rb_color_yellow.Checked)
            {
                colour = "yellow";
            }
            return colour;
        }
        private void addProcess()
        {
            cal_arrivaltime();
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && Convert.ToInt32(textbox_arrival.Text) <= arrival)
            {
                int arrivalTime = 0;
                try
                {
                    BurstTime = Convert.ToInt32(textBox2.Text);
                    arrivalTime = Convert.ToInt32(textbox_arrival.Text);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Please Enter an Intger");
                }
                Naam = textBox1.Text;
                foreach(var v in data)
                {
                    //Make sure no two Processes have the same Name
                    if(Naam == v[0])
                    {
                        return;
                    }
                }
                checkedListBox1.Items.Add(Naam + "," + " BT: " + BurstTime + ",AT: " + arrivalTime);
                string[] name = { Naam, Convert.ToString(BurstTime) };
                // Adds a string array Process Name, Burst, Oringal Arrival Time, Waiting Time ,Color of Process
                data.Add(new string[] { Naam, Convert.ToString(BurstTime), arrivalTime.ToString(),""+0, getColor() });
                totalarrival.Add(BurstTime);
                cal_arrivaltime();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                process = null;
                process = new Shortest(pre);
            }
        }
        private void processData()
        {
            if (data.Count > 1 && process != null)
            {
                processedData = process.processRequest(data);
                listView1.Items.Clear();
                foreach (string[] str in processedData)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = str[0];
                    item.SubItems.Add(str[1]);
                    item.SubItems.Add(str[2]);
                    item.SubItems.Add(str[3]);
                    listView1.Items.Add(item);
                }
            }
        }
        private void processBarStart()
        {
            int processes = processedData.Count;
            int totalBurst = 0;
            Graphics g = panel1.CreateGraphics();
            foreach(var v in processedData)
            {
                totalBurst = totalBurst + Convert.ToInt32(v[1]);
            }

            while (paused == 1 && pos[0] < processes) {
                SolidBrush brush = new SolidBrush(getColor(processedData[pos[0]][4]));

                //Gets the current Process and continues drawing the Process
                for (int i = pos[1]; pos[1] != Convert.ToInt32(processedData[pos[0]][1]); i++)
                {
                    //Draws a Process
                    Decimal breed = Decimal.Divide(width,totalBurst);
                    int w = Convert.ToInt32(Math.Floor(breed));
                    g.FillRectangle(brush, x, y, w, 40);
                    x += w;
                    if (label_percentage.InvokeRequired)
                    {
                        Decimal per = Decimal.Divide(pos[2],totalBurst);
                          per = Convert.ToInt32(per  * 100);
                        
                        label_percentage.Invoke(new MethodInvoker(delegate { label_percentage.Text = ("Percentage: " + per.ToString() + " %").ToString(); }));
                    }
                    

                    pos[1]++;
                    pos[2]++;
                    Thread.Sleep(1000);

                    if(pos[2] == totalBurst )
                    {//Complete
                        g.FillRectangle(brush, x, y, w, 40);
                        if (label_percentage.InvokeRequired)
                        {
                            label_percentage.Invoke(new MethodInvoker(delegate { label_percentage.Text = ("Percentage: 100% "); }));
                        }
                        paused = -1;
                        MessageBox.Show("Processes Complete");
                        return;
                    }
                    else if(pos[1] == Convert.ToInt32(processedData[pos[0]][1]))
                    {//if Drawing current process is complete move to the next process
                        pos[0]++;
                        pos[1] = 0;
                        break;
                    }
                    
                     
                }
            }
            }
        
        private void processBarContinue()
        {

        }
        private Color getColor(string color)
        {
        if(color == "yellow")
        {
            return Color.Yellow;
        }
        else if(color == "green")
        {
            return Color.Green;
        }
        else if(color == "blue")
        {
            return Color.Blue;
        }
        else if(color == "white")
            {
                return Color.Transparent;
            }
        else
        {
            return Color.Red;
        }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            paused = 0;
        }
        private void restartBar()
        {
            x = 0;
            paused = -1;
            pos[0] = 0;
            pos[1] = 0;
            pos[2] = 0;
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void cal_arrivaltime()
        {
            int sum = 0;
            if(totalarrival.Count != 0)
            {
                foreach(var v in totalarrival)
                {
                    sum = sum + v;
                }
            }
            labelArrival.Text = "Maximum Arrival Time Input " + sum;
            arrival = sum;
        }

        private void labelArrival_Click(object sender, EventArgs e)
        {

        }
    }
}
