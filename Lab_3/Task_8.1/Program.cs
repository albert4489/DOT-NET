using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputDatPath = "..\\..\\..\\dat\\8.1.dat";

            // Записуємо в бінарний файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputDatPath, FileMode.OpenOrCreate)))
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;

                Console.Write("Введіть рядок: ");
                string input = Console.ReadLine();

                // Заміна кожної крапки трьома крапками
                string modifiedInput = input.Replace(".", "...");

                // Розділення рядка на слова
                string[] words = modifiedInput.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                int wordCount = words.Length;

                writer.Write("\n");
                writer.Write("Введений рядок із замінами: ");
                for (int i = 0; i < wordCount; i++)
                {
                    writer.Write($"{words[i]} ");
                }
            }

            // читаємо з того ж файлу
            using (BinaryReader reader = new BinaryReader(File.Open(outputDatPath, FileMode.Open)))
            {

                // виводимо вміст
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string line = reader.ReadString();
                    Console.Write(line);
                }
            }

            Console.ReadKey();
        }
    }
}