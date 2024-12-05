using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;
            
            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;

            button3.MouseEnter += Button_MouseEnter;    
            button3.MouseLeave += Button_MouseLeave;
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Size = new Size(button.Size.Width + 2, button.Size.Height + 2);
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Size = new Size(button.Size.Width - 2, button.Size.Height - 2);
            }
        }

    }
}
