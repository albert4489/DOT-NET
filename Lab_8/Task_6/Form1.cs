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
            this.item221ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item222ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item223ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);

            this.item331ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item332ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item333ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item334ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);

            this.item441ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item442ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item443ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item444ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            this.item445ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

            if (clickedItem != null)
            {
                ToolStripMenuItem parentItem = clickedItem.OwnerItem as ToolStripMenuItem;
                if (parentItem != null)
                {
                    MessageBox.Show($"Розділ: {parentItem.Text}, Назва пункта меню: {clickedItem.Text}");
                }
                else
                {
                    MessageBox.Show($"Назва пункта меню: {clickedItem.Text}");
                }
            }
        }
    }
}
