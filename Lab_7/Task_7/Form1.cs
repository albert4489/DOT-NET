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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 2, label1.Font.Style);

            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size - 2, label1.Font.Style);

            }
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size + 2, label2.Font.Style);

            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size - 2, label2.Font.Style);

            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size + 2, label3.Font.Style);

            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size - 2, label3.Font.Style);

            }
        }
    }
}
