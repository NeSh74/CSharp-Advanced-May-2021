using System;
using System.Linq;

namespace _3_Primary_Diagonal
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

            int diagonalSum = 0;
            int cols = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                diagonalSum += matrix[rows, cols];
                cols += 1;
            }

            Console.WriteLine(diagonalSum);

        }
    }
}
