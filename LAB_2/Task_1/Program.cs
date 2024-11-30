using System;
using System.Linq;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Random random = new Random();
            int[] Ar = new int[50];
            int[] ResAr = new int[50];

            for (int i = 0; i < 50; i++)
            {
                Ar[i] = random.Next(-100, 101);
            }

            Console.WriteLine("Початковий Масив:");
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{Ar[i],10}  ");
            }

            int MinPos = Ar.Where(x => x > 0).Min();

            for (int i = 0; i < 50; i++)
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
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{ResAr[i],10}  ");
            }
            Console.ReadKey();
        }
    }
}
