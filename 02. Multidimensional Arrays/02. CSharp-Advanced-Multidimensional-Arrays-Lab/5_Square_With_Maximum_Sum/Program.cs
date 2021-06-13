using System;
using System.Linq;

namespace _5_Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = readArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] arr = readArrayFromConsole();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int maxSum = int.MinValue;
            int mxRow = 0;
            int mxCol = 0;
            for (int row = 0; row < sizes[0] - 1; row++)
            {
                for (int col = 0; col < sizes[1] - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        mxRow = row;
                        mxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[mxRow, mxCol]} {matrix[mxRow, mxCol + 1]}");
            Console.WriteLine($"{matrix[mxRow + 1, mxCol]} {matrix[mxRow + 1, mxCol + 1]}");
            Console.WriteLine(maxSum);
        }
        private static int[] readArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
