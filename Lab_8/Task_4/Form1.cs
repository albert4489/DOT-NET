using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text; 
            string name = textBox2.Text;

            string age = comboBox1.SelectedItem?.ToString() ?? "Не вибрано";

            string gender = radioButton1.Checked ? "Чоловік" : (radioButton2.Checked ? "Жінка" : "Не вибрано");

            List<string> interests = new List<string>();
            if (checkBox1.Checked) interests.Add("Комп'ютери");
            if (checkBox2.Checked) interests.Add("Спорт");
            if (checkBox3.Checked) interests.Add("Мистецтво");
            if (checkBox4.Checked) interests.Add("Наука");

            string interestsText = interests.Count > 0 ? string.Join(", ", interests) : "Не вибрано";

            string opinion;

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                string filePath = textBox3.Text;

                if (File.Exists(filePath))
                {
                    try
                    {
                        opinion = File.ReadAllText(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при читанні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Вказаный файл не знайден. Перевыте шлях", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                opinion = textBox4.Text;
            }

            string message = $"Пароль: {password}\n" +
                     $"Ім'я: {name}\n" +
                     $"Вік: {age}\n" +
                     $"Стать: {gender}\n" +
                     $"Інтереси: {interestsText}\n" +
                     $"Думка: {opinion}";

            MessageBox.Show(message, "Вибрані параметри форми");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Всі файли (*.*)|*.*";
            openFileDialog.Title = "Выберіть файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBox3.Text = filePath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

            comboBox1.SelectedIndex = -1;

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
