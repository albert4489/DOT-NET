using System;

namespace Task_8
{
    internal class Program
    {
        static int[][] RotateMatrix90(int[][] oldMatrix)
        {
            int rows = oldMatrix.Length;
            int columns = oldMatrix[0].Length;
            int[][] newMatrix = new int[columns][];

            for (int i = 0; i < columns; i++)
            {
                newMatrix[i] = new int[rows];
            }

            for (int oldRow = 0; oldRow < rows; oldRow++)
            {
                for (int oldColumn = 0; oldColumn < columns; oldColumn++)
                {
                    newMatrix[oldColumn][rows - oldRow - 1] = oldMatrix[oldRow][oldColumn];
                }
            }

            return newMatrix;
        }

        static int[][] GenerateRandomMatrix(int rows, int columns)
        {
            Random random = new Random();
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    matrix[i][j] = random.Next(1, 101);
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

            int[][] matrix = GenerateRandomMatrix(rows, columns);

            Console.WriteLine("\nПоточна матриця:");
            foreach (var row in matrix)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Join("\t", row));
                Console.ResetColor();
            }

            int[][] rotatedMatrix = RotateMatrix90(matrix);

            Console.WriteLine("\nМатриця результат:");
            foreach (var row in rotatedMatrix)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Join("\t", row));
                Console.ResetColor();
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
