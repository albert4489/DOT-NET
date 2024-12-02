using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3;

namespace Task_3
{
    class Complex
    {
        public double r, i;

        public Complex()
        {
            this.r = 0.0;
            this.i = 0.0;
        }

        public Complex(double real, double imag)
        {
            this.r = real;
            this.i = imag;
        }

        public static Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }

        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r * b.r - a.i * b.i;
            res.i = a.i * b.r + a.r * b.i;
            return res;
        }

        public static Complex Subtract(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }

        public static Complex Division(Complex a, Complex b)
        {
            Complex res = new Complex();
            double denominator = b.r * b.r + b.i * b.i;
            if (denominator == 0)
            {
                throw new DivideByZeroException("Ділення на 0");
            }
            res.r = (a.r * b.r + a.i * b.i) / denominator;
            res.i = (a.i * b.r - a.r * b.i) / denominator;
            return res;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return Complex.Sum(a, b);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return Complex.Subtract(a, b);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return Complex.Multiplication(a, b);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return Complex.Division(a, b);
        }

        public Complex Clone()
        {
            return new Complex { r = this.r, i = this.i };
        }

        public Complex(Complex other)
        {
            this.r = other.r;
            this.i = other.i;
        }

        public override string ToString()
        {
            return $"({r:F3} + {i:F3}i)";
        }
    }


    internal class Program
    {
        // Функція для додавання двох векторів комплексних чисел
        static List<Complex> AddVectors(List<Complex> vector1, List<Complex> vector2)
        {
            if (vector1.Count != vector2.Count)
            {
                throw new ArgumentException("Вектори мають різну довжину");
            }

            List<Complex> result = new List<Complex>();
            for (int i = 0; i < vector1.Count; i++)
            {
                result.Add(vector1[i] + vector2[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Random random = new Random();

            // Створення двох векторів з випадковими комплексними числами
            int vectorSize = 2;
            List<Complex> vector1 = new List<Complex>();
            List<Complex> vector2 = new List<Complex>();

            for (int i = 0; i < vectorSize; i++)
            {
                vector1.Add(new Complex(random.NextDouble() * 10, random.NextDouble() * 10));
                vector2.Add(new Complex(random.NextDouble() * 10, random.NextDouble() * 10));
            }

            Console.WriteLine("Вектор 1:");
            vector1.ForEach(c => Console.WriteLine(c));

            Console.WriteLine("\nВектор 2:");
            vector2.ForEach(c => Console.WriteLine(c));

            // Додавання векторів
            var resultVector = AddVectors(vector1, vector2);

            Console.WriteLine("\nРезультат додавання векторів:");
            resultVector.ForEach(c => Console.WriteLine(c));
            Console.ReadLine();
        }

    }
}

