using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.червонийToolStripMenuItem.Click += new System.EventHandler(this.ChangeColor);
            this.зеленийToolStripMenuItem.Click += new System.EventHandler(this.ChangeColor);
            this.жовтийToolStripMenuItem.Click += new System.EventHandler(this.ChangeColor);
            this.помаранчевийToolStripMenuItem.Click += new System.EventHandler(this.ChangeColor);

        }
        private void ChangeColor(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                Color selectedColor = Color.Black;

                switch (menuItem.Text)
                {
                    case "Червоний":
                        selectedColor = Color.Red;
                        break;
                    case "Зелений":
                        selectedColor = Color.Green;
                        break;
                    case "Жовтий":
                        selectedColor = Color.Yellow;
                        break;
                    case "Помаранчевий":
                        selectedColor = Color.Orange;
                        break;
                }
                label1.ForeColor = selectedColor;
                label2.ForeColor = selectedColor;
                label3.ForeColor = selectedColor;
            }
        }
    }
}
