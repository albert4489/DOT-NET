using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Purple };

            this.BackColor = colors[colorIndex];

            colorIndex = (colorIndex + 1) % colors.Length;
        }

        private int colorIndex = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 250;
            timer1.Start();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval += 100;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 100)
            {
                timer1.Interval -= 100;
            }
        }
    }
}
