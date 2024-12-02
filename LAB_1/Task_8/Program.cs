using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
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
            double eps;
            double maxterms;
            bool reachedEps = false;
            Console.Write("Введіть похибку: ");
            eps = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть кількість членів ряду: ");
            maxterms = Convert.ToDouble(Console.ReadLine());

            for (n = 0; n < maxterms ; n++)
            {
                dbln = n;

                term = Math.Pow(-1, n) / ((dbln + 1) * (dbln + 2) * (dbln + 3));

                sum += term;

                if (Math.Abs(term) < eps)
                {
                    reachedEps = true;
                    break;
                }

            }
            if (reachedEps)
            {
                Console.WriteLine($"Ряд обчислений при досягненні заданої похибки (похибка < {eps}).");
            }
            else
            {
                Console.WriteLine($"Ряд обчислений після досягнення {maxterms} членів.");
            }
            Console.WriteLine($"Сума ряду = {sum.ToString("F7")}");
            Console.ReadLine();
        }
    }
}
