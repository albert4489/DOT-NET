using System;

namespace Task_5
{
    internal class Program
    {
        static int[][] RotateMatrix90(int[][] oldMatrix)
        {
            int rows = oldMatrix.Length;
            int cols = oldMatrix[0].Length;
            int[][] newMatrix = new int[cols][];
            for (int i = 0; i < cols; i++)
                newMatrix[i] = new int[rows];

            for (int oldRow = rows - 1, newColumn = 0; oldRow >= 0; oldRow--, newColumn++)
            {
                for (int oldColumn = 0; oldColumn < cols; oldColumn++)
                {
                    newMatrix[oldColumn][newColumn] = oldMatrix[oldRow][oldColumn];
                }
            }

            return newMatrix;
        }

        static void Main(string[] args)
        {
            int[][] matrix9x9 = new int[9][];
            int value = 1;
            for (int i = 0; i < 9; i++)
            {
                matrix9x9[i] = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    matrix9x9[i][j] = value++;
                }
            }
            int[][] rotatedMatrix = RotateMatrix90(matrix9x9);

            for (int i = 0; i < rotatedMatrix.Length; i++)
            {
                for (int j = 0; j < rotatedMatrix[i].Length; j++)
                {
                    Console.Write(rotatedMatrix[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
