using System;
using System.Collections.Generic;

namespace Task_9
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

            for (int i = 0; i < size; i++)
            {
                Ar[i] = random.Next(1, 101);
            }

            Console.WriteLine("Масив:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{Ar[i],10}  ");
            }
            Console.WriteLine();

            var numberCounts = new Dictionary<int, int>();

            foreach (var num in Ar)
            {
                if (numberCounts.ContainsKey(num))
                {
                    numberCounts[num]++;
                }
                else
                {
                    numberCounts[num] = 1;
                }
            }

            int maxNumber = int.MinValue;
            int count = 0;

            foreach (var pair in numberCounts)
            {
                if (pair.Value > 1 && pair.Key > maxNumber)
                {
                    maxNumber = pair.Key;
                    count = pair.Value;
                }
            }

            if (maxNumber != int.MinValue)
            {
                Console.WriteLine($"Найбільше число, яке зустрічається більше 1 разу: {maxNumber}, кількість: {count}");
            }
            else
            {
                Console.WriteLine("Немає чисел, які зустрічаються більше одного разу.");
            }

            Console.ReadLine();
        }
    }
}
