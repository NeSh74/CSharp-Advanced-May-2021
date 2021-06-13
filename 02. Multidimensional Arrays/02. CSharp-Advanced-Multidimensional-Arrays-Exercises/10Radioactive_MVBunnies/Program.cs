using System;
using System.Collections.Generic;
using System.Linq;

namespace _10Radioactive_MVBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            char[,] matrix = new char[rows, cols];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < rows; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                    if (rowData[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();
            bool isPlayerWon = false;
            bool isPlayerDead = false;
            foreach (char direction in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                switch (direction)
                {
                    case 'U':
                        newPlayerRow--;
                        break;
                    case 'D':
                        newPlayerRow++;
                        break;
                    case 'L':
                        newPlayerCol--;
                        break;
                    case 'R':
                        newPlayerCol++;
                        break;
                }

                matrix[playerRow, playerCol] = '.';
                isPlayerWon = !IsvalidCell(newPlayerRow, newPlayerCol, rows, cols);
                if (!isPlayerWon)
                {
                    if (matrix[newPlayerRow, newPlayerCol] == '.')
                    {
                        matrix[newPlayerRow, newPlayerCol] = 'P';
                    }
                    else if (matrix[newPlayerRow, newPlayerCol] == 'B')
                    {
                        isPlayerDead = true;
                    }

                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                }

                List<int[]> currentBunnyIdx = GetBunnyIdxs(matrix);
                SpeadBunnies(currentBunnyIdx, matrix);
                if (matrix[playerRow, playerCol] == 'B')
                {
                    isPlayerDead = true;
                }

                if (isPlayerWon || isPlayerDead)
                {
                    break;
                }
            }

            PrintMatrix(matrix);
            string result = string.Empty;
            if (isPlayerWon)
            {
                result += "won:";
            }
            else
            {
                result += "dead:";
            }

            result += $" {playerRow} {playerCol}";
            Console.WriteLine(result);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                    ;
                }

                Console.WriteLine();
            }
        }

        static void SpeadBunnies(List<int[]> currentBunnyIdx, char[,] matrix)
        {
            foreach (int[] bunnyIndexes in currentBunnyIdx)
            {
                int bunnyRow = bunnyIndexes[0];
                int bunnyCol = bunnyIndexes[1];
                if (IsvalidCell(bunnyRow - 1, bunnyCol, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    matrix[bunnyRow - 1, bunnyCol] = 'B';
                }

                if (IsvalidCell(bunnyRow + 1, bunnyCol, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    matrix[bunnyRow + 1, bunnyCol] = 'B';
                }
                if (IsvalidCell(bunnyRow, bunnyCol - 1, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    matrix[bunnyRow, bunnyCol - 1] = 'B';
                }
                if (IsvalidCell(bunnyRow, bunnyCol + 1, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    matrix[bunnyRow, bunnyCol + 1] = 'B';
                }
            }
        }

        static List<int[]> GetBunnyIdxs(char[,] matrix)
        {
            List<int[]> bunnies = new List<int[]>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunnies.Add(new[] { row, col });
                    }
                }
            }

            return bunnies;
        }

        static bool IsvalidCell(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }
}
