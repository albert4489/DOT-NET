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

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedPrice = 0;
            if (radioButton1.Checked)
                selectedPrice = 4969;
            else if (radioButton2.Checked)
                selectedPrice = 11412;
            else if (radioButton3.Checked)
                selectedPrice = 6552;
            if (!int.TryParse(textBox1.Text, out int multiplier) || multiplier <= 0)
            {
                MessageBox.Show("Введіть більше 0.");
                return;
            }

            int result = selectedPrice * multiplier;
            label2.Text = result.ToString("N0") + " грн";

        }
    }
}
