using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLine = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> secondLine = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int totalLoot = 0;

            while (firstLine.Count > 0 && secondLine.Count > 0)
            {
                int first = firstLine.Peek();
                int second = secondLine.Peek();
                int sum = first + second;

                if (sum % 2 == 0)
                {
                    totalLoot += sum;
                    firstLine.Dequeue();
                    secondLine.Pop();
                }
                else
                {
                    firstLine.Enqueue(secondLine.Pop());
                }
            }

            string result = firstLine.Count < secondLine.Count ? "First lootbox is empty" : "Second lootbox is empty";
            string score = totalLoot >= 100 ?
                $"Your loot was epic! Value: {totalLoot}" : $"Your loot was poor... Value: {totalLoot}";
            Console.WriteLine(result);
            Console.WriteLine(score);
        }
    }
}
