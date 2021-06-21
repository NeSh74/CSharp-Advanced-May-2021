using System;
using System.Security.Principal;

namespace _02Super_Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            var lives = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());

            char[][] maze = new char[rows][];
            var currRow = 0;
            var currCol = 0;

            for (int row = 0; row < maze.GetLength(0); row++)
            {
                var mazeRow = Console.ReadLine();
                maze[row] = new char[mazeRow.Length];

                for (int col = 0; col < mazeRow.Length; col++)
                {
                    maze[row][col] = mazeRow[col];
                    if (maze[row][col] == 'M')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            bool missionAcomplished = false;
            while (true)
            {
                var moves = Console.ReadLine().Split();
                var direction = char.Parse(moves[0]);
                var spawnRow = int.Parse(moves[1]);
                var spawnCol = int.Parse(moves[2]);

                maze[spawnRow][spawnCol] = 'B';
                lives--;
                switch (direction)
                {
                    case 'W':
                        if (currRow - 1 < 0)
                        {
                            continue;
                        }

                        maze[currRow][currCol] = '-';
                        currRow--;
                        break;
                    case 'S':
                        if (currRow + 1 == rows)
                        {
                            continue;
                        }

                        maze[currRow][currCol] = '-';
                        currRow++;
                        break;
                    case 'A':
                        if (currCol - 1 < 0)
                        {
                            continue;
                        }

                        maze[currRow][currCol] = '-';
                        currCol--;
                        break;
                    case 'D':
                        if (currCol + 1 == maze[currRow].Length)
                        {
                            continue;
                        }

                        maze[currRow][currCol] = '-';
                        currCol++;
                        break;
                }

                if (lives <= 0)
                {
                    maze[currRow][currCol] = 'X';
                    break;
                }

                if (maze[currRow][currCol] == 'B')
                {
                    lives -= 2;
                    if (lives <= 0)
                    {
                        maze[currRow][currCol] = 'X';
                        break;
                    }
                }
                else if (maze[currRow][currCol] == 'P')
                {
                    missionAcomplished = true;
                    maze[currRow][currCol] = '-';
                    break;
                }

                maze[currRow][currCol] = 'M';
            }

            if (missionAcomplished)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else
            {
                Console.WriteLine($"Mario died at {currRow};{currCol}.");
            }

            foreach (char[] row in maze)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
