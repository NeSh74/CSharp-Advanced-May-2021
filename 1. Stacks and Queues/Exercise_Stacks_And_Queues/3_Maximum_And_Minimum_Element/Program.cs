using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Maximum_And_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < queries; i++)
            {
                int[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = cmd[0];

                switch (command)
                {
                    case 1:
                        stack.Push(cmd[1]);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Stack<int> reverse = stack;

            Console.WriteLine(string.Join(", ", reverse));
        }
    }
}
