using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть рядок: ");
            string input = Console.ReadLine();

            // Видалення тексту в круглих дужках разом із самими дужками
            string textWithoutParentheses = System.Text.RegularExpressions.Regex.Replace(input, "\\(.*?\\)", "").Trim();

            // Розділення рядка на слова, пропускаючи пробільні символи
            string[] words = textWithoutParentheses.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Підрахунок слів з непарною довжиною
            int oddLengthWordCount = words.Count(word => word.Length % 2 != 0);

            // Підрахунок частоти входження кожної літери
            Dictionary<char, int> Frequency = new Dictionary<char, int>();
            foreach (char c in textWithoutParentheses.Replace(" ", ""))
            {
                if (char.IsLetter(c))
                {
                    char lowerChar = char.ToLower(c);
                    if (Frequency.ContainsKey(lowerChar))
                    {
                        Frequency[lowerChar]++;
                    }
                    else
                    {
                        Frequency[lowerChar] = 1;
                    }
                }
            }

            Console.WriteLine();

            // Виведення всіх слів
            Console.WriteLine("Введений рядок без тексту в дужках: " + textWithoutParentheses);

            // Виведення кількості слів з непарною довжиною
            Console.WriteLine("Кількість слів з непарною довжиною: " + oddLengthWordCount);

            // Виведення частоти входження кожної літери
            Console.WriteLine("Частота входження кожної літери:");
            foreach (var entry in Frequency)
            {
                Console.WriteLine($"Літера '{entry.Key}': {entry.Value}");
            }

            Console.ReadLine();
        }
    }
}
