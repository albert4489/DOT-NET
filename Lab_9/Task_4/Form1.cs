using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float inputValue))
            {
                float result = inputValue * 0.207f;
                label2.Text = "Ліга: " + result.ToString("F3");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox2.Text, out float inputValue))
            {
                float result = inputValue / 0.207f;
                label4.Text = "Кілометри: " + result.ToString("F3");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = !string.IsNullOrEmpty(textBox2.Text);
        }
    }
}
