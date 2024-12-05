using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Task_6
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

            double accessoryPrice = 0;
            if (checkBox1.Checked) accessoryPrice += 200;
            if (checkBox2.Checked) accessoryPrice += 2000;
            if (checkBox3.Checked) accessoryPrice += 300;
            if (checkBox4.Checked) accessoryPrice += 1000;
            label3.Text = $"Ціна аксесуарів: {accessoryPrice} грн";

            double discount = accessoryPrice * 0.1;

            double totalPriceUAH = basePrice + accessoryPrice - discount;

            double conversionRate = 1;

            string currencySymbol = "грн";

            if (checkBox5.Checked)
            {
                conversionRate = 37;
                currencySymbol = "USD";
            }
            double totalPriceConverted = totalPriceUAH / conversionRate;

            label2.Text = $"Ціна у базовій комплектації: {basePrice / conversionRate:F2} {currencySymbol}";
            label3.Text = $"Ціна аксесуарів: {accessoryPrice / conversionRate:F2} {currencySymbol}";
            label4.Text = $"10% знижка на аксесуари: {discount / conversionRate:F2} {currencySymbol}";
            label5.Text = $"Ціна за все разом: {totalPriceConverted:F2} {currencySymbol}";
        }

    }
}