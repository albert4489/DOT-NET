using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string inputFilePath = "..\\..\\..\\txt\\text.txt";
            string outputFilePath = "..\\..\\..\\txt\\7.3.txt";

            try
            {
                using (StreamReader sr = new StreamReader(inputFilePath))
                using (StreamWriter sw = new StreamWriter(outputFilePath))
                {
                    string input = sr.ReadLine();
                    // Розділення рядка на слова, пропускаючи пробільні символи
                    string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    int wordCount = words.Length;
                    int a = 0;  // Лічильник символів о

                    sw.WriteLine();
                    sw.Write("Введений рядок: ");
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
                        sw.Write($"{words[i]} ");
                    }

                    sw.WriteLine();
                    sw.WriteLine($"Кількість літер о: {a}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Опис: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Стоп.");
            }
            Console.ReadKey();
        }
    }
}
