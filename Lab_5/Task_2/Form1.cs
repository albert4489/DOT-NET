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
            this.Load += MyLabel;
        }

        private void MyLabel(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Text = "Велосипед";
            label1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Green;
            label1.Font = new Font("Times New Roman", 15, FontStyle.Italic);
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(48, 168);
            label1.AutoSize = true;
            this.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "Автомобіль";
            label2.BackColor = Color.Red;
            label2.ForeColor = Color.Yellow;
            label2.Font = new Font("Times New Roman", 17, FontStyle.Bold);
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Location = new Point(306, 165);
            label2.AutoSize = true;
            this.Controls.Add(label2);

            Label label3 = new Label();
            label3.Text = "Мотоцикл";
            label3.BackColor = Color.Red;
            label3.ForeColor = Color.Gray;
            label3.Font = new Font("Times New Roman", 11, FontStyle.Underline);
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(603, 173);
            label3.AutoSize = true;
            this.Controls.Add(label3);
        }
    }
}
