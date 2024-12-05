using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddLabel()
        {
            Label newLabel = new Label();
            newLabel.Text = "Label1";
            newLabel.BackColor = Color.Transparent;
            newLabel.Location = new Point(50, 50);
            newLabel.AutoSize = true;
            this.Controls.Add(newLabel);
        }

        private void RemoveLabel()
        {
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label && control.BackColor == Color.Transparent)
                    {
                        this.Controls.Remove(control);
                        break;
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.A)
                {
                    AddLabel();
                }
                else if (e.KeyCode == Keys.D)
                {
                    RemoveLabel();
                }
            }
        }
    }
}
