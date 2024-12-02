using System;
using System.Linq;

namespace Task_2
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

            Console.WriteLine("Початковий Масив:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{Ar[i],10}  ");
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

            Console.WriteLine("\n\nМасив-Результат:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{ResAr[i],10}  ");
            }

            Console.ReadLine();
        }
    }
}
