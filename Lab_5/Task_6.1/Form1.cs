using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6._1
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
                Size = new Size(180, 300),
                Location = new Point(12, 112),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ImageLocation = "..\\..\\..\\img\\1.jpg"
            };
            this.Controls.Add(pictureBox1);

            PictureBox pictureBox2 = new PictureBox()
            {
                Size = new Size(180, 200),
                Location = new Point(212, 212),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ImageLocation = "..\\..\\..\\img\\2.jpg"
            };
            this.Controls.Add(pictureBox2);

            PictureBox pictureBox3 = new PictureBox()
            {
                Size = new Size(180, 300),
                Location = new Point(412, 112),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ImageLocation = "..\\..\\..\\img\\1.jpg"
            };
            this.Controls.Add(pictureBox3);

            PictureBox pictureBox4 = new PictureBox()
            {
                Size = new Size(180, 200),
                Location = new Point(612, 212),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ImageLocation = "..\\..\\..\\img\\2.jpg"
            };
            this.Controls.Add(pictureBox4);

            PictureBox pictureBox5 = new PictureBox()
            {
                Size = new Size(180, 300),
                Location = new Point(812, 112),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ImageLocation = "..\\..\\..\\img\\1.jpg"
            };
            this.Controls.Add(pictureBox5);

        }
    }
}
