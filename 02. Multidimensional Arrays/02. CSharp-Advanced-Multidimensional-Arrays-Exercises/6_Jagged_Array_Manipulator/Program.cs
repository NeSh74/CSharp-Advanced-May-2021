using System;
using System.Linq;

namespace _6_Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedMatrix = new double[n][];
            //for (int row = 0; row < n; row++)
            //{
            //    int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //    for (int col = 0; col < rowData .Length ; col++)
            //    {
            //        jaggedMatrix[row][col] = rowData[col];
            //    }
            //}
            for (int row = 0; row < n; row++)
            {
                //double[] rowData = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
                //jaggedMatrix[row] = rowData;
                jaggedMatrix[row] = Console.ReadLine().Split(" ").Select(double.Parse).ToArray(); ;
            }

            for (int row = 0; row < n - 1; row++)
            {
                double[] firstArr = jaggedMatrix[row];
                double[] secondArr = jaggedMatrix[row + 1];
                if (firstArr.Length == secondArr.Length)
                {
                    jaggedMatrix[row] = firstArr.Select(e => e * 2).ToArray();
                    jaggedMatrix[row + 1] = secondArr.Select(e => e * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[row] = firstArr.Select(e => e / 2).ToArray();
                    jaggedMatrix[row + 1] = secondArr.Select(e => e / 2).ToArray();
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandData = command.Split(" ");
                int rowIdx = int.Parse(commandData[1]);
                int colIdx = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);

                bool isvalidCell = rowIdx >= 0 && rowIdx < n &&
                                   colIdx >= 0 && colIdx < jaggedMatrix[rowIdx].Length;
                if (!isvalidCell)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (commandData[0] == "Add")
                {
                    jaggedMatrix[rowIdx][colIdx] += value;
                }
                else if (commandData[0] == "Subtract")
                {
                    jaggedMatrix[rowIdx][colIdx] -= value;
                }
                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedMatrix[row]));
            }
        }
    }
}
