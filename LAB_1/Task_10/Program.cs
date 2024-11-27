using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            short n;
            double x, y = 0;
            double h;
            for (n = 0; n < 5; n++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("│   x   │      у     │");
                Console.WriteLine("├───────┼────────────┤");
                for (x = 0; x < 4; x += 0.16)
                {
                    if (x < 1)
                        y = 1;
                    else if (x < 3)
                    {
                        double temp = 1 - (x - 2) * (x - 2);
                        y = temp >= 0 ? 1 - Math.Sqrt(temp) : 0;
                    }
                    else
                        y = 1;

                    Console.WriteLine("│ {0,5:F2} │ {1,10:F7} │", x + n * 4, y);

                    h = (y + 1) * 25;
                    if (y - 1 - h * 10 > 0.5) h++;
                    for (; h > 0; h--) Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("/");

                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Натисніть клавішу Enter...");
                Console.ReadKey();
            }
        }
    }
}