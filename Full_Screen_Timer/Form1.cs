using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Full_Screen_Timer
{
    public partial class Form1 : Form
    {
        int time = 0,x,y,z;
        public Form1()
        {
            InitializeComponent();
            settime();
            if (DateTime.Now.Hour < 12)
                label2.Text = "AM";
            else
                label2.Text = "PM";
            label2.Text = DateTime.Now.ToLongDateString();
           // localfunction();    
        }

        public void settime()
        {
            x = DateTime.Now.Hour;
            y = DateTime.Now.Minute;
            z = DateTime.Now.Second;
            if (x > 12)
                x -= 12;
            if (x == 0)
                x = 12;
            if (x < 10)
                label1.Text = "0" + x.ToString();
            else
                label1.Text = x.ToString();
            if (y < 10)
                label4.Text = "0" + y.ToString();
            else
                label4.Text = y.ToString();
            if (z < 10)
                label5.Text = "0" + z.ToString();
            else
                label5.Text = z.ToString();
            label6.Text = DateTime.Now.Millisecond.ToString();
            label7.Text = z % 2 == 0 ? ":" : " ";
            label8.Text = label7.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            settime();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
