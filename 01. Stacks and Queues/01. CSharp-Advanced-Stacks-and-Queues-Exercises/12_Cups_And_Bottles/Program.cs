using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Cups_And_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> bottles = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int wastedWater = 0;
            int curCups = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                curCups = curCups > 0 ? curCups : cups.Peek();
                int curBottles = bottles.Pop();

                if (curCups - curBottles <= 0)
                {
                    cups.Dequeue();
                    wastedWater += Math.Abs(curCups - curBottles);
                    curCups -= curBottles;
                }
                else
                {
                    curCups -= curBottles;
                }
            }

            string answer = cups.Count > 0 ? $"Cups: {string.Join(" ", cups)}" : $"Bottles: {string.Join(" ", bottles)}";

            Console.WriteLine(answer);
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
