using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string name1, name2, name3;
            char sc1, sc2, sc3;
            string place1, place2, place3;
            int np1, np2, np3;
            Console.WriteLine("1. Введіть: назву, групу, житло, чисельність популяції > ");
            name1 = Console.ReadLine();
            sc1 = Convert.ToChar(Console.ReadLine());
            place1 = Console.ReadLine();
            np1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Введіть: назву, групу, житло, чисельність популяції > ");
            name2 = Console.ReadLine();
            sc2 = Convert.ToChar(Console.ReadLine());
            place2 = Console.ReadLine();
            np2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. Введіть: назву, групу, житло, чисельність популяції > ");
            name3 = Console.ReadLine();
            sc3 = Convert.ToChar(Console.ReadLine());
            place3 = Console.ReadLine();
            np3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("| Деякі види антилоп                                                  |");
            Console.WriteLine("|---------------------------------------------------------------------|");
            Console.WriteLine("| Назва    | Група | Житло  | Чисельність популяції                   |");
            Console.WriteLine("|----------|-------|--------|-----------------------------------------|");
            Console.WriteLine($"| {name1,-8} | {sc1,-5} | {place1,-6} | {np1,-39} |");
            Console.WriteLine($"| {name2,-8} | {sc2,-5} | {place2,-6} | {np2,-39} |");
            Console.WriteLine($"| {name3,-8} | {sc3,-5} | {place3,-6} | {np3,-39} |");
            Console.WriteLine("|---------------------------------------------------------------------|");
            Console.WriteLine("| А – справжні антилопи, B – коров’ячі антилопи, H – кінські антилопи |");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
