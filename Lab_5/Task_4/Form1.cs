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
            this.Load += MyTextBox;
        }

        private void MyTextBox(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Text = "Автомобіль";
            textBox1.BackColor = Color.Red;
            textBox1.ForeColor = Color.Yellow;
            textBox1.Font = new Font("Times New Roman", 17, FontStyle.Bold);
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Location = new Point(48, 168);
            textBox1.Width = 130;
            this.Controls.Add(textBox1);

            TextBox textBox2 = new TextBox();
            textBox2.Text = "Велосипед";
            textBox2.BackColor = Color.Yellow;
            textBox2.ForeColor = Color.Green;
            textBox2.Font = new Font("Times New Roman", 15, FontStyle.Italic);
            textBox2.TextAlign = HorizontalAlignment.Left;
            textBox2.Location = new Point(306, 165);
            textBox2.Width = 106;
            this.Controls.Add(textBox2);

            TextBox textBox3 = new TextBox();
            textBox3.Text = "Мотоцикл";
            textBox3.BackColor = Color.Gray;
            textBox3.ForeColor = Color.Red;
            textBox3.Font = new Font("Times New Roman", 11, FontStyle.Underline);
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.Location = new Point(603, 173);
            textBox3.Width = 97;
            this.Controls.Add(textBox3);
        }
    }
}
