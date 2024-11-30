using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine();
            Console.Write("Рядок з великими літерами: ");
            for (int i = 0; i < wordCount; i++)
            {
                Console.Write($"{words[i]} ");
            }

            Console.ReadKey();
        }
    }
}
