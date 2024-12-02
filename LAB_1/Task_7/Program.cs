using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            long n;
            double dbln;
            double sum = 0;
            double term;
            const double eps = 0.000001;

            for (n = 0; ; n++)
            {
                dbln = n;

                term = Math.Pow(-1, n) / ((dbln + 1) * (dbln + 2) * (dbln + 3));

                if (Math.Abs(term) >= eps)
                {
                    sum += term;
                }
                else
                {
                    break;
                }
                if (n == 9)
                {
                    Console.WriteLine($"Сума 10-ти членів ряду = {sum.ToString("F7")}");
                }
            }
            Console.WriteLine($"Повна сума ряду = {sum.ToString("F7")}");
            Console.ReadLine();
        }
    }
}
