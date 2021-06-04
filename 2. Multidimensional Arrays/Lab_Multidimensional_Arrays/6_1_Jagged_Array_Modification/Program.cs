using System;
using System.Linq;

namespace _6_1_Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];
            for (int i = 0; i < n; i++)
            {
                jagged[i] = ReadArrayFromConsole();
            }

            string command = Console.ReadLine()?.ToUpper();
            while (command != "END")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(token[1]);
                int col = int.Parse(token[2]);
                int value = int.Parse(token[3]);
                if (row < 0 || row >= n || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine()?.ToUpper();
                    continue;
                }
                switch (token[0])
                {
                    case "ADD":
                        jagged[row][col] += value;
                        break;
                    case "SUBTRACT":
                        jagged[row][col] -= value;
                        break;
                }
                command = Console.ReadLine()?.ToUpper();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(' ', jagged[i]));
            }
        }
        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
