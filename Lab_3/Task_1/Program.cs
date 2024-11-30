using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть строку: ");

            string input = Console.ReadLine();

            // Розділення рядка на слова, пропускаючи пробільні символи
            string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length; // Кількість слів у рядку

            Console.WriteLine("\nРезультат:");

            // Виводимо слово та його номер у тексті
            for (int i = 0; i < wordCount; i++)
            {
                Console.WriteLine($"{words[i]} - {i + 1}");
            }

            Console.WriteLine($"\nКількість слів у тексті: {wordCount}");
            Console.ReadKey();
        }
    }
}
