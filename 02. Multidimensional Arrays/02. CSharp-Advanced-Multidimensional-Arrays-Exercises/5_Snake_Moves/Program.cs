using System;
using System.Linq;

namespace _5_Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string snake = Console.ReadLine();
            string[,] matrix = new string[sizes[0], sizes[1]];
            int counter = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = snake[counter].ToString();
                    counter++;
                    if (counter == snake.Length)
                    {
                        counter = 0;
                    }
                }
                if (r % 2 == 0)
                {
                    r++;
                    if (r == matrix.GetLength(0))
                    {
                        break;
                    }
                    for (int k = matrix.GetLength(1) - 1; k >= 0; k--)
                    {
                        matrix[r, k] = snake[counter].ToString();
                        counter++;
                        if (counter == snake.Length)
                        {
                            counter = 0; ;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
