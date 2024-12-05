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
            label1.DoubleClick += new System.EventHandler(label_DoubleClick);
            label2.DoubleClick += new System.EventHandler(label_DoubleClick);
            label3.DoubleClick += new System.EventHandler(label_DoubleClick);
        }
        private void label_DoubleClick(object sender, EventArgs e)
        {
            if(sender == label1)
            {
                Font currentFont = label1.Font;

                float newFontSize = currentFont.Size + 2;

                Font newFont = new Font(currentFont.FontFamily, newFontSize, currentFont.Style);

                label1.Font = newFont;
            }
            else if(sender == label2)
            {
                Font currentFont = label2.Font;

                float newFontSize = currentFont.Size + 2;

                Font newFont = new Font(currentFont.FontFamily, newFontSize, currentFont.Style);

                label2.Font = newFont;
            }
            else if (sender == label3)
            {
                Font currentFont = label3.Font;

                float newFontSize = currentFont.Size + 2;

                Font newFont = new Font(currentFont.FontFamily, newFontSize, currentFont.Style);

                label3.Font = newFont;
            }
        }
    }
}
