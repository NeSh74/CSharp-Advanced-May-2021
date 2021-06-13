using System;
using System.Linq;

namespace _9_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            char[,] matrix = new char[n, n];
            int coalsCollected = 0;

            MatrixInput(matrix);

            int[] curPos = FindStartingPossition(matrix);
            int totalCoals = FindTotalCoals(matrix);
            int mRow = curPos[0];
            int mCol = curPos[1];
            string output = string.Empty;

            for (int i = 0; i < cmd.Length; i++)
            {
                string command = cmd[i];

                switch (command)
                {
                    case "left":
                        if (mCol > 0)
                        {
                            if (matrix[mRow, mCol - 1] == 'c')
                            {
                                coalsCollected++;
                                totalCoals--;
                                matrix[mRow, mCol - 1] = 's';
                                matrix[mRow, mCol] = '*';
                                mCol -= 1;
                            }
                            else if (matrix[mRow, mCol - 1] == '*')
                            {
                                matrix[mRow, mCol - 1] = 's';
                                matrix[mRow, mCol] = '*';
                                mCol -= 1;
                            }
                            else if (matrix[mRow, mCol - 1] == 'e')
                            {
                                mCol -= 1;
                                output = "GameOver";
                                break;
                            }
                        }
                        break;
                    case "right":
                        if (mCol < matrix.GetLength(1) - 1)
                        {
                            if (matrix[mRow, mCol + 1] == 'c')
                            {
                                coalsCollected++;
                                totalCoals--;
                                matrix[mRow, mCol + 1] = 's';
                                matrix[mRow, mCol] = '*';
                                mCol += 1;
                            }
                            else if (matrix[mRow, mCol + 1] == '*')
                            {
                                matrix[mRow, mCol + 1] = 's';
                                matrix[mRow, mCol] = '*';
                                mCol += 1;
                            }
                            else if (matrix[mRow, mCol + 1] == 'e')
                            {
                                mCol += 1;
                                output = "GameOver";
                                break;
                            }
                        }
                        break;
                    case "up":
                        if (mRow > 0)
                        {
                            if (matrix[mRow - 1, mCol] == 'c')
                            {
                                coalsCollected++;
                                totalCoals--;
                                matrix[mRow - 1, mCol] = 's';
                                matrix[mRow, mCol] = '*';
                                mRow -= 1;
                            }
                            else if (matrix[mRow - 1, mCol] == '*')
                            {
                                matrix[mRow - 1, mCol] = 's';
                                matrix[mRow, mCol] = '*';
                                mRow -= 1;
                            }
                            else if (matrix[mRow - 1, mCol] == 'e')
                            {
                                mRow -= 1;
                                output = "GameOver";
                                break;
                            }
                        }
                        break;
                    case "down":
                        if (mRow < matrix.GetLength(0) - 1)
                        {
                            if (matrix[mRow + 1, mCol] == 'c')
                            {
                                coalsCollected++;
                                totalCoals--;
                                matrix[mRow + 1, mCol] = 's';
                                matrix[mRow, mCol] = '*';
                                mRow += 1;
                            }
                            else if (matrix[mRow + 1, mCol] == '*')
                            {
                                matrix[mRow + 1, mCol] = 's';
                                matrix[mRow, mCol] = '*';
                                mRow += 1;
                            }
                            else if (matrix[mRow + 1, mCol] == 'e')
                            {
                                mRow += 1;
                                output = "GameOver";
                                break;
                            }
                        }
                        break;
                }
                if (totalCoals == 0)
                {
                    output = "CoalsCollected";
                    break;
                }
            }

            if (output == "CoalsCollected")
            {
                Console.WriteLine($"You collected all coals! ({mRow}, {mCol})");
            }
            else if (output == "GameOver")
            {
                Console.WriteLine($"Game over! ({mRow}, {mCol})");
            }
            else if (output == string.Empty)
            {
                Console.WriteLine($"{totalCoals} coals left. ({mRow}, {mCol})");
            }
        }

        public static int FindTotalCoals(char[,] matrix)
        {
            int coals = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == 'c')
                    {
                        coals++;
                    }
                }
            }
            return coals;
        }

        public static int[] FindStartingPossition(char[,] matrix)
        {
            int[] possition = new int[2];
            bool isFound = false;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == 's')
                    {
                        possition[0] = r;
                        possition[1] = c;
                        isFound = true;
                        break;
                    }
                }
                if (isFound) break;
            }
            return possition;
        }

        public static char[,] MatrixInput(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = char.Parse(inputData[c]);
                }
            }
            return matrix;
        }
    }
}
