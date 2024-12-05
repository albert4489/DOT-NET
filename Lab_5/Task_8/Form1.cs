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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 5,
                Dock = DockStyle.Fill
            };

            for (int i = 0; i < 3; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
                
            }

            for (int i = 0; i < 5; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); 
            }

            var button1 = new Button { Text = "button1", Width = 100, Dock = DockStyle.Left };
            var button2 = new Button { Text = "button2", Width = 100, Dock = DockStyle.Fill };
            var button3 = new Button { Text = "button3", Width = 100, Dock = DockStyle.Right };
            var button4 = new Button { Text = "button4", Width = 100, Dock = DockStyle.Right };
            var button5 = new Button { Text = "button5", Width = 100, Dock = DockStyle.Left };

            tableLayoutPanel.Controls.Add(button1, 0, 0);
            tableLayoutPanel.Controls.Add(button2, 2, 1);
            tableLayoutPanel.Controls.Add(button3, 0, 2);
            tableLayoutPanel.Controls.Add(button4, 4, 0);
            tableLayoutPanel.Controls.Add(button5, 4, 2);

            this.Controls.Add(tableLayoutPanel);
            this.Size = new System.Drawing.Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
