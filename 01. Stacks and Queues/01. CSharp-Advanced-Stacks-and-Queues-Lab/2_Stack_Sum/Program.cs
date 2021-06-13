using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> numbers = new Stack<int>(input);
            string command = Console.ReadLine().ToUpper();
            while (command != "END")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "ADD":
                        numbers.Push(int.Parse(tokens[1]));
                        numbers.Push(int.Parse(tokens[2]));
                        break;
                    case "REMOVE":
                        int count = int.Parse(tokens[1]);
                        if (numbers.Count >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Pop();
                            }
                        }
                        break;
                }
                command = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Sum: " + numbers.Sum());
        }
    }
}
