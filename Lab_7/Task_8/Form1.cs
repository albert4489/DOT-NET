using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.MouseDown += label_MouseDown;
            label2.MouseDown += label_MouseDown;
            label3.MouseDown += label_MouseDown;

            label1.MouseUp += label_MouseUp;
            label2.MouseUp += label_MouseUp;
            label3.MouseUp += label_MouseUp;
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;  

            if (label != null && e.Button == MouseButtons.Left)
            {
                label.Font = new Font(label.Font.FontFamily, label.Font.Size + 2, label.Font.Style);
            }
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            Label label = sender as Label; 

            if (label != null && e.Button == MouseButtons.Left)
            {
                label.Font = new Font(label.Font.FontFamily, label.Font.Size - 2, label.Font.Style);
            }
        }
    }
}
