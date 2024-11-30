using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputDatPath = "..\\..\\..\\dat\\8.2.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputDatPath, FileMode.OpenOrCreate)))
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;

                Console.Write("Введіть рядок: ");

                string input = Console.ReadLine();
                // Розділення рядка на слова, пропускаючи пробільні символи
                string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // Перетворення перших букв кожного слова на великі
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }

                int wordCount = words.Length;

                writer.Write("\n");
                writer.Write("Рядок з великими літерами: ");
                for (int i = 0; i < wordCount; i++)
                {
                    writer.Write($"{words[i]} ");
                }
            }
            using (BinaryReader reader = new BinaryReader(File.Open(outputDatPath, FileMode.Open)))
            {

                // виводимо вміст
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string line = reader.ReadString();
                    Console.Write(line);
                }
            }
            Console.ReadLine();
        }
    }
}
