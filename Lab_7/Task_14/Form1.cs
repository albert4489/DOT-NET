using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            DialogResult result = MessageBox.Show(
                "Чи хочете ви завантажити форму?",
                "Запит", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question); 


            if (result == DialogResult.Yes)
            {

                this.Location = new Point(0, 0);
                this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2); 
            }
            else
            {
                this.Close();
            }
        }
    }
}