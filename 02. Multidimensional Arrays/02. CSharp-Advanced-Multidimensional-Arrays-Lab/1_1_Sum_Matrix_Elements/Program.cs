using System;
using System.Linq;

namespace _1_1_Sum_Matrix_Elements
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

            Console.WriteLine(sizes[0]);
            Console.WriteLine(sizes[1]);
            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(sum);
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
