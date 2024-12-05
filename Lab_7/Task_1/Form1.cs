using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Напис1";
            label.Location = new Point(10, 10);
            this.Controls.Add(label);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Label label = new Label();
                label.Text = "Напис2";
                label.Location = new Point(10, 10);
                this.Controls.Add(label);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Напис3";
            label.Location = new Point(10, 10);
            this.Controls.Add(label);
        }
    }
}
