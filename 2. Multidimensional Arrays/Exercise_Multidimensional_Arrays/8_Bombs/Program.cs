using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowData[c];
                }
            }

            Queue<int> bombs = new Queue<int>(Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            while (bombs.Count > 0)
            {
                int bombR = bombs.Dequeue();
                int bombC = bombs.Dequeue();

                if (matrix[bombR, bombC] <= 0)
                {
                    continue;
                }
                else
                {
                    int bombValue = matrix[bombR, bombC];
                    BombExpodion(matrix, bombR, bombC, bombValue);
                }
            }

            int activeCells = 0;
            int activeCellsSum = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] > 0)
                    {
                        activeCells++;
                        activeCellsSum += matrix[r, c];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {activeCells}");
            Console.WriteLine($"Sum: { activeCellsSum}");
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] BombExpodion(int[,] matrix, int r, int c, int bombValue)
        {
            for (int row = r - 1; row < r + 2; row++)
            {
                for (int col = c - 1; col < c + 2; col++)
                {
                    if (IsIndexValid(matrix, row, col))
                    {
                        if (matrix[row, col] > 0)
                        {
                            matrix[row, col] -= bombValue;
                        }
                    }
                }
            }
            return matrix;
        }

        public static bool IsIndexValid(int[,] matrix, int r, int c)
        {
            if ((r >= 0 && r < matrix.GetLength(0))
                && c >= 0 && c < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
