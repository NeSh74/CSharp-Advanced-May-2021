using System;
using System.ComponentModel.Design;

namespace _03.Space_Station_Establishment
{
    public class StartUP
    {
        private const int MIN_STAR_POWERNEEDED = 50;
        private static char[][] galaxy;

        private static int playerRow;
        private static int playerCol;
        private static int collectedEnergy;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FillGalaxy(n);
            while (collectedEnergy < MIN_STAR_POWERNEEDED)
            {
                string direction = Console.ReadLine();
                int nextRow = playerRow;
                int nextCol = playerCol;
                DetermineNextCoordinatesByDirection(direction, ref nextRow ,ref nextCol);
                bool isOutsideOfTheGalaxy = CheckIfPlayerIsOutsideOfTheField(nextRow, n, nextCol);
                if (isOutsideOfTheGalaxy)
                {
                    galaxy[playerRow][playerCol] = '-';
                    break;
                }
                ProceedMove(nextRow, nextCol, n);
            }

            PrintOutput(n);
        }

        private static void PrintOutput(int n)
        {
            if (collectedEnergy >= MIN_STAR_POWERNEEDED)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }

            Console.WriteLine($"Star power collected: {collectedEnergy}");
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join("", galaxy[row]));
            }
        }

        private static bool CheckIfPlayerIsOutsideOfTheField(int nextRow, int n, int nextCol)
        {
            return nextRow < 0 || nextRow >= n ||
                   nextCol < 0 || nextCol >= n;
        }

        private static void DetermineNextCoordinatesByDirection(string direction, ref int nextRow, ref int nextCol)
        {
            //int nextRow;
            //int nextCol;
            if (direction == "up")
            {
                nextRow = playerRow - 1;
                nextCol = playerCol;
                //ProceedMove(ref nextRow, ref nextCol, n);
            }
            else if (direction == "down")
            {
                nextRow = playerRow + 1;
                nextCol = playerCol;
            }
            else if (direction == "left")
            {
                nextRow = playerRow;
                nextCol = playerCol - 1;
            }
            else if (direction == "right")
            {
                nextRow = playerRow;
                nextCol = playerCol + 1;
            }
        }

        private static void ProceedMove( int nextRow, int nextCol, int n)
        {
            char nextSymbol = galaxy[nextRow][nextCol];

            if (char.IsDigit(nextSymbol))
            {
                int starEnergy = nextSymbol - 48;
                collectedEnergy += starEnergy;
            }
            else if (nextSymbol == 'O')
            {
                TrvelTroughBlackHoles(ref nextRow, ref nextCol, n);
            }

            galaxy[nextRow][nextCol] = 'S';
            galaxy[playerRow][playerCol] = '-';

            playerRow = nextRow;
            playerCol = nextCol;
        }

        private static void TrvelTroughBlackHoles(ref int nextRow, ref int nextCol, int n)
        {
            galaxy[nextRow][nextCol] = '-';
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    char iterSymbol = galaxy[row][col];
                    if (iterSymbol == 'O')
                    {
                        nextRow = row;
                        nextCol = col;
                    }
                }
            }
        }

        private static void FillGalaxy(int n)
        {
            galaxy = new char[n][];
            bool found = false;
            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                if (!found)
                {
                    for (int col = 0; col < currentRow.Length; col++)
                    {
                        if (currentRow[col] == 'S')
                        {
                            playerRow = row;
                            playerCol = col;
                            found = true;
                            break;
                        }
                    }
                }

                galaxy[row] = currentRow;
            }
        }
    }
}
