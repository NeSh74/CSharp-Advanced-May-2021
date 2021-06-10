using System;
using System.Linq;

namespace _3_3_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[size[0], size[1]];
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < size[0]; i++)
            {
                int[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            for (int row = 0; row < size[0] - 2; row++)
            {
                for (int col = 0; col < size[1] - 2; col++)
                {
                    int sum = GetTheSumOf3x3(row, col, matrix);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxCol = col;
                        maxRow = row;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxRow; row <= maxRow + 2; row++)
            {
                for (int col = maxCol; col <= maxCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int GetTheSumOf3x3(int row, int col, int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    sum += matrix[row + i, col + j];
                }
            }

            return sum;
        }
    }
}
