using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть розмір масиву: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Некоректне значення. Введіть додатне ціле число:");
            }

            Random random = new Random();
            List<int> Ar = new List<int>();
            List<int> ResAr = new List<int>();

            for (int i = 0; i < size; i++)
            {
                Ar.Add(random.Next(-100, 101));
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Початковий Масив:");
            Console.ResetColor();
            foreach (var item in Ar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{item,10}  ");
                Console.ResetColor();
            }

            int MinPos = Ar.Where(x => x > 0).Min();

            for (int i = 0; i < Ar.Count; i++)
            {
                if (Ar[i] < 0)
                {
                    ResAr.Add(MinPos);
                }
                else
                {
                    ResAr.Add(Ar[i]);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nМасив-Результат:");
            Console.ResetColor();
            for (int i = 0; i < ResAr.Count; i++)
            {
                if (Ar[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{ResAr[i],10}  ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{ResAr[i],10}  ");
                    Console.ResetColor();
                }
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
