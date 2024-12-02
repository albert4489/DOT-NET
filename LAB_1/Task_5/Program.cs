using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть координату x >");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть координату y >");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"x = {x}, y = {y}");

            if ((-1 <= x) && (x <= 1) && (-1 <= y) && (y <= 1) && (y >= x))
            {
                Console.WriteLine("Точка потрапляє в задану область");
            }
            else
            {
                Console.WriteLine("Точка не потрапляє в задану область");
            }

            Console.ReadLine();

        }
    }
}
