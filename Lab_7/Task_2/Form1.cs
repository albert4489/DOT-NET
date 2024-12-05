using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new System.EventHandler(button_Click);
            button2.Click += new System.EventHandler(button_Click);
            button3.Click += new System.EventHandler(button_Click);
        }
        private void button_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Location = new Point(10, 10);

            if (sender == button1)
            {
                label.Text = "Напис1";
            }
            else if (sender == button2)
            {
                label.Text = "Напис2";
            }
            else if (sender == button3)
            {
                label.Text = "Напис3";
            }
            this.Controls.Add(label);
        }
    }
}
