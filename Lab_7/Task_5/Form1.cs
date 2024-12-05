using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new Size(button1.Size.Width + 2, button1.Size.Height + 2);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(button1.Size.Width - 2, button1.Size.Height - 2);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Size = new Size(button2.Size.Width + 2, button2.Size.Height + 2);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(button2.Size.Width - 2, button2.Size.Height - 2);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Size = new Size(button3.Size.Width + 2, button3.Size.Height + 2);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(button3.Size.Width - 2, button3.Size.Height - 2);
        }
    }
}
