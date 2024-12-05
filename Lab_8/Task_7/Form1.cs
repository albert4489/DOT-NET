using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void червонийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
        }

        private void зеленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
        }

        private void жовтийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
            label2.ForeColor = Color.Yellow;
            label3.ForeColor = Color.Yellow;
        }

        private void помаранчевийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Orange;
            label2.ForeColor = Color.Orange;
            label3.ForeColor = Color.Orange;
        }
    }
}
