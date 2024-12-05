using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Enter += TextBox_FocusChanged;
            textBox1.Leave += TextBox_FocusChanged;

            textBox2.Enter += TextBox_FocusChanged;
            textBox2.Leave += TextBox_FocusChanged;

            textBox3.Enter += TextBox_FocusChanged;
            textBox3.Leave += TextBox_FocusChanged;
        }

        private void TextBox_FocusChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {

                if (e is EventArgs)
                {
                    if (this.ActiveControl == textBox) 
                    {
                        textBox.Size = new Size(textBox.Size.Width + 2, textBox.Size.Height + 2);
                    }
                    else
                    {
                        textBox.Size = new Size(textBox.Size.Width - 2, textBox.Size.Height - 2);
                    }
                }
            }
        }
    }
}