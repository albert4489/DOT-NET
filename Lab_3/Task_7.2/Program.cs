using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string inputFilePath = "..\\..\\..\\txt\\text.txt";
            string outputFilePath = "..\\..\\..\\txt\\7.2.txt";

            try
            {
                using (StreamReader sr = new StreamReader(inputFilePath))
                using (StreamWriter sw = new StreamWriter(outputFilePath))
                {

                    string input = sr.ReadLine();
                    if (input == null)
                    {
                        Console.WriteLine("Файл порожній або не містить даних.");
                        return;
                    }
                    // Розділення рядка на слова, пропускаючи пробільні символи
                    string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    int wordCount = words.Length; // Кількість слів у рядку

                    sw.WriteLine("\nРезультат:");

                    // Виводимо слово та його номер у тексті
                    for (int i = wordCount - 1; i >= 0; i--)
                    {
                        sw.WriteLine($"{words[i]} - {wordCount - i}");
                    }

                    sw.WriteLine($"\nКількість слів у тексті: {wordCount}");
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
