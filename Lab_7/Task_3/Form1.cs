using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            Font currentFont = label1.Font;

            float newFontSize = currentFont.Size + 2;

            Font newFont = new Font(currentFont.FontFamily, newFontSize, currentFont.Style);

            label1.Font = newFont;

        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            Font currentFont = label2.Font;

            float newFontSize = currentFont.Size + 2;

            Font newFont = new Font(currentFont.FontFamily, newFontSize, currentFont.Style);

            label2.Font = newFont;
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            Font currentFont = label3.Font;

            float newFontSize = currentFont.Size + 2;

            Font newFont = new Font(currentFont.FontFamily, newFontSize, currentFont.Style);

            label3.Font = newFont;
        }
    }
}
