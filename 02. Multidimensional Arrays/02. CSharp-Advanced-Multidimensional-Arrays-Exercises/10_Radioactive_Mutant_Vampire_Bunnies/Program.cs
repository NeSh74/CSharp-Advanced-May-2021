using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = dimentions[0];
            int m = dimentions[1];
            char[,] field = new char[n, m];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                char[] rowdata = Console.ReadLine().ToCharArray();
                for (int col = 0; col < m; col++)
                {
                    field[row, col] = rowdata[col];
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] direcions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;
            foreach (char direction in direcions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;
                if (direction == 'U')
                {
                    newPlayerRow--;
                }
                else if (direction == 'D')
                {
                    newPlayerRow++;
                }
                else if (direction == 'L')
                {
                    newPlayerCol--;
                }
                else if (direction == 'R')
                {
                    newPlayerCol++;
                }

                if (!IsValidCell(newPlayerRow, newPlayerCol, n, m))
                {
                    isWon = true;
                    field[playerRow, playerCol] = '.';
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                }
                else if (field[newPlayerRow, newPlayerCol] == '.')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                    if (field[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                    }
                }
                else if (field[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                }

                if (isDead || isWon)
                {
                    break;
                }
            }

            PrintField(field);
            string res = "";
            if (isWon)
            {
                res += "won";
            }
            else
            {
                res += "dead";
            }

            res += $": {playerRow} {playerCol}";
            Console.WriteLine(res);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void SpreadBunnies(List<int[]> bunniesCoordinates, char[,] field)
        {

            foreach (int[] bunniesCoordinate in bunniesCoordinates)
            {
                int row = bunniesCoordinate[0];
                int col = bunniesCoordinate[1];
                SpeadBunny(row - 1, col, field);
                SpeadBunny(row + 1, col, field);
                SpeadBunny(row, col - 1, field);
                SpeadBunny(row, col + 1, field);

            }
        }

        private static void SpeadBunny(int row, int col, char[,] field)
        {
            int rowsLenght = field.GetLength(0);
            int colsLenght = field.GetLength(1);
            if (IsValidCell(row, col, rowsLenght, colsLenght))
            {
                field[row, col] = 'B';
            }
        }

        private static List<int[]> GetBunniesCoordinates(char[,] field)
        {
            List<int[]> bunniesCoordinates = new List<int[]>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        bunniesCoordinates.Add(new int[] { row, col });
                    }
                }
            }

            return bunniesCoordinates;
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
