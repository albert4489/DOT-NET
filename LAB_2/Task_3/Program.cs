using System;
using System.Linq;

namespace Task_3
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
            int[] Ar = new int[size];
            int[] ResAr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Ar[i] = random.Next(-100, 101);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Початковий Масив:");
            Console.ResetColor();
            for (int i = 0; i < size; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{Ar[i],10}  ");
                Console.ResetColor();
            }

            int MinPos = Ar.Where(x => x > 0).Min();

            for (int i = 0; i < size; i++)
            {
                if (Ar[i] < 0)
                {
                    ResAr[i] = MinPos;
                }
                else
                {
                    ResAr[i] = Ar[i];
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nМасив-Результат:");
            Console.ResetColor();
            for (int i = 0; i < size; i++)
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
