using System;
using System.Linq;

namespace _4_Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = dimentions[0];
            int m = dimentions[1];

            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }



            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] commandData = command.Split(" ");

                if (commandData.Length != 5 || commandData[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int rowOne = int.Parse(commandData[1]);
                int colOne = int.Parse(commandData[2]);
                int rowTwo = int.Parse(commandData[3]);
                int colTwo = int.Parse(commandData[4]);

                bool isValidOne = rowOne >= 0 && rowOne < n &&
                                  colOne >= 0 && colOne < m;
                bool isValidTwo = rowTwo >= 0 && rowTwo < n &&
                                  colTwo >= 0 && colTwo < m;
                //bool isOutOfMatrix = rowOne < 0 || rowOne >= n ||
                //                     colOne < 0 || colOne >= m;

                if (!isValidOne || !isValidTwo)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string valueOne = matrix[rowOne, colOne];
                string valueTwo = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = valueTwo;
                matrix[rowTwo, colTwo] = valueOne;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < m; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
