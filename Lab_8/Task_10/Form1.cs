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
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton5.Click += new System.EventHandler(this.ToolStripButton_Click);
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton clickedButton = sender as ToolStripButton;

            if (clickedButton != null)
            {
                switch (clickedButton.Name)
                {
                    case "toolStripButton1":
                        MessageBox.Show("Підказка1", "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "toolStripButton2":
                        MessageBox.Show("Підказка2", "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "toolStripButton3":
                        MessageBox.Show("Підказка3", "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "toolStripButton4":
                        MessageBox.Show("Підказка4", "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "toolStripButton5":
                        MessageBox.Show("Підказка5", "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
        }
    }
}
