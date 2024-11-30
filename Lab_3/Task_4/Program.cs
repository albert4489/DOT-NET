using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть рядок: ");

            string input = Console.ReadLine();

            // Заміна кожної крапки трьома крапками
            string modifiedInput = input.Replace(".", "...");

            // Розділення рядка на слова, пропускаючи пробільні символи
            string[] words = modifiedInput.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            Console.WriteLine();
            Console.Write("Введений рядок із замінами: ");
            for (int i = 0; i < wordCount; i++)
            {
                Console.Write($"{words[i]} ");
            }

            Console.ReadKey();
        }
    }
}
