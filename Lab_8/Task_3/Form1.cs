using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox3.Checked = true;

            checkBox2.Checked = false;
            checkBox4.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
            label4.ForeColor = Color.Green;
        }
    }
}
