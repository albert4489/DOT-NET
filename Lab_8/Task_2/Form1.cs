using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton7.Checked = true;

            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton8.Checked = false;
            radioButton6.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
            label4.ForeColor = Color.Green;

            label6.ForeColor = Color.Orange;
            label7.ForeColor = Color.Orange;
            label8.ForeColor = Color.Orange;
        }
    }
}
