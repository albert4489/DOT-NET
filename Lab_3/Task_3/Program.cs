using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
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

            int wordCount = words.Length;
            int a = 0;  // Лічильник символів о

            Console.WriteLine();
            Console.Write("Введений рядок: ");
            // Перевірка кожного символа на наявність  о
            foreach (char c in input)
            {
                if (c == 'о')
                {
                    a++;
                }
            }

            // Виведення всіх слів
            for (int i = 0; i < wordCount; i++)
            {
                Console.Write($"{words[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Кількість літер о: {a}");

            Console.ReadKey();
        }
    }
}
