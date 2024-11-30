using System;

namespace Task_6
{
    internal class Program
    {
        static int[,] RotateMatrix90(int[,] oldMatrix)
        {
            int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newColumn = 0, newRow;
            for (int oldRow = oldMatrix.GetLength(0) - 1; oldRow >= 0; oldRow--)
            {
                newRow = 0;
                for (int oldColumn = 0; oldColumn < oldMatrix.GetLength(1); oldColumn++)
                {
                    newMatrix[newRow, newColumn] = oldMatrix[oldRow, oldColumn];
                    newRow++;
                }
                newColumn++;
            }
            return newMatrix;
        }

        static int[,] GenerateRandomMatrix(int rows, int columns)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 101); 
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть кількість рядків: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовбців: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = GenerateRandomMatrix(rows, columns);

            Console.WriteLine("\nПоточна матриця:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] rotatedMatrix = RotateMatrix90(matrix);

            Console.WriteLine("\nМатриця результат:");
            for (int i = 0; i < rotatedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < rotatedMatrix.GetLength(1); j++)
                {
                    Console.Write(rotatedMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
