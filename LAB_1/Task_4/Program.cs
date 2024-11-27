using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
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
            try
            {

                Console.Write("Введіть значення x: ");
                x = Convert.ToDouble(Console.ReadLine());


                Console.Write("Введіть значення y: ");
                y = Convert.ToDouble(Console.ReadLine());
                if (y == 0)
                {
                    throw new DivideByZeroException("y не може бути рівним нулю, оскільки це призведе до ділення на нуль.");
                }

                if (y * x + c <= 0)
                {
                    throw new ArgumentException("Вираз під логарифмом (y * x + c) повинен бути більше нуля.");
                }

                ax = a * x;
                t1 = (ax / y) + (b / (y * y)) * Math.Log10(y * x + c);

                if ((c - b) * (c + b) < 0)
                {
                    throw new ArgumentException("Вираз під квадратним коренем ((c - b) * (c + b)) повинен бути невід'ємним.");
                }
                if (ax - b == 0)
                {
                    throw new DivideByZeroException("Знаменник у виразі ((ax + b) / (ax - b)) не може бути нулем.");
                }

                ax = Math.Sqrt((c - b) * (c + b)) * Math.Tan(ax);
                t2 = Math.Log((ax + b) / (ax - b)) / 2 / a / b;

                Console.WriteLine($"t1 = {t1}");
                Console.WriteLine($"t2 = {t2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введено некоректне число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непередбачена помилка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Програма завершена.");
                Console.ReadKey();
            }

           }
        }
    }

