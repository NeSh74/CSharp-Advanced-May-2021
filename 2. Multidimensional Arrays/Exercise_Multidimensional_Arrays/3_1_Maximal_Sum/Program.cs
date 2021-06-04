using System;
using System.Linq;

namespace _3_1_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            int[,] matrix = ReadMatrix(rows, cols);
            int bestSum = 0;
            int bestRowIdx = 0;
            int bestColIdx = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int firstRowSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int secondRowSum = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int thirdRowSum = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    int currentSum = firstRowSum + secondRowSum + thirdRowSum;
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRowIdx = row;
                        bestColIdx = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {bestSum}");
            for (int row = bestRowIdx; row <= bestRowIdx + 2; row++)
            {
                for (int col = bestColIdx; col <= bestColIdx + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            return matrix;
        }
    }
}
