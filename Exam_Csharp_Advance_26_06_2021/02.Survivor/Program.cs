using System;
using System.Linq;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            int collectedTokens = 0;
            int opponentTokens = 0;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Gong")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                switch (command)
                {
                    case "Find":

                        if (IsValid(matrix, row, col))
                        {
                            if (matrix[row][col] == 'T')
                            {
                                matrix[row][col] = '-';

                                collectedTokens++;
                            }
                        }

                        break;

                    case "Opponent":

                        string direction = tokens[3];

                        if (IsValid(matrix, row, col))
                        {
                            if (matrix[row][col] == 'T')
                            {
                                matrix[row][col] = '-';

                                opponentTokens++;
                            }

                            for (int i = 0; i < 3; i++)
                            {
                                switch (direction)
                                {
                                    case "up": row--; break;
                                    case "down": row++; break;
                                    case "left": col--; break;
                                    case "right": col++; break;
                                }

                                if (IsValid(matrix, row, col))
                                {
                                    if (matrix[row][col] == 'T')
                                    {
                                        matrix[row][col] = '-';

                                        opponentTokens++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        break;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }

        private static bool IsValid(char[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix[row].Length;
        }
    }
}
