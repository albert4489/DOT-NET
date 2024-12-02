using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            double x, y;
            double a = 12.5;
            double b = 1.3; 
            double c = 14.1;
            double t1, t2;
            double ax;

            Console.Write("Введіть значення x: ");
            x = Convert.ToDouble(Console.ReadLine());


            Console.Write("Введіть значення y: ");
            y = Convert.ToDouble(Console.ReadLine());

            ax = a * x; 
            t1 = (ax / y) + (b / (y * y)) * Math.Log10(y * x + c);

            ax = Math.Sqrt((c - b) * (c + b)) * Math.Tan(ax);
            t2 = Math.Log((ax + b) / (ax - b)) / 2 / a / b;

            Console.WriteLine($"t1 = {t1}");
            Console.WriteLine($"t2 = {t2}");
            Console.ReadLine();
        }
    }
}
