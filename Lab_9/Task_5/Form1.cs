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

        private void button1_Click(object sender, EventArgs e)
        {
            double basePrice = 4969;

            label2.Text = $"Ціна у базовій комплектації: {basePrice} грн";

            double accessoryPrice = 0;
            if (checkBox1.Checked) accessoryPrice += 200;
            if (checkBox2.Checked) accessoryPrice += 2000;
            if (checkBox3.Checked) accessoryPrice += 300;
            if (checkBox4.Checked) accessoryPrice += 1000;
            label3.Text = $"Ціна аксесуарів: {accessoryPrice} грн";

            double discount = accessoryPrice * 0.1;
            label4.Text = $"10% знижка на аксесуари: {discount} грн";

            double  totalPrice = basePrice + accessoryPrice - discount;
            label5.Text = $"Ціна за все разом: {totalPrice} грн";
        }
    }
}
