using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox()
            {
                Size = new Size(128, 164),
                Location = new Point(12, 261),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ImageLocation = "..\\..\\..\\img\\3.jpg"
            };
            this.Controls.Add(pictureBox1);

            PictureBox pictureBox2 = new PictureBox()
            {
                Size = new Size(256, 164),
                Location = new Point(156, 261),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ImageLocation = "..\\..\\..\\img\\4.jpg"
            };
            this.Controls.Add(pictureBox2);

            PictureBox pictureBox3 = new PictureBox()
            {
                Size = new Size(128, 164),
                Location = new Point(429, 261),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ImageLocation = "..\\..\\..\\img\\3.jpg"
            };
            this.Controls.Add(pictureBox3);
        }
    }
}
