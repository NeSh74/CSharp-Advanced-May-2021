using System;

namespace _4_Symbol_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] rowData = Console.ReadLine()
                    .ToCharArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowData[c];
                }
            }

            char x = char.Parse(Console.ReadLine());
            bool xFound = false;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (x == matrix[r, c])
                    {
                        Console.WriteLine($"({r}, {c})");
                        xFound = true;
                        break;
                    }

                    if (xFound) break;

                }
            }

            if (!xFound)
            {
                Console.WriteLine($"{x} does not occur in the matrix");
            }
        }
    }
}
