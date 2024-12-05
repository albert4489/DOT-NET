using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox
            {
                Location = new System.Drawing.Point(50,50),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            comboBox.Items.AddRange(new string[] { "Київ", "Харків", "Полтава", "Одеса", "Львів", "Ізюм" });

            this.Controls.Add(comboBox);

            ListBox listBox = new ListBox
            {
                Location = new System.Drawing.Point(200, 50),
                Size = new System.Drawing.Size(120, 100)
            };

            listBox.Items.AddRange(new string[] { "Київ", "Харків", "Полтава", "Одеса", "Львів", "Ізюм" });

            this.Controls.Add(listBox);
        }
    }
}
