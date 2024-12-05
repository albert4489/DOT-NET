using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Size = new Size(textBox1.Size.Width + 2, textBox1.Size.Height + 2);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Size = new Size(textBox1.Size.Width - 2, textBox1.Size.Height - 2);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Size = new Size(textBox2.Size.Width + 2, textBox2.Size.Height + 2);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.Size = new Size(textBox2.Size.Width - 2, textBox2.Size.Height - 2);
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Size = new Size(textBox3.Size.Width + 2, textBox3.Size.Height + 2);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.Size = new Size(textBox3.Size.Width - 2, textBox3.Size.Height - 2);
        }
    }
}
