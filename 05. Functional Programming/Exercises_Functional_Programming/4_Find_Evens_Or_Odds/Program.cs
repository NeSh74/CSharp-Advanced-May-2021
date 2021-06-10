using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Find_Evens_Or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var querry = Console.ReadLine();
            Predicate<int> predicate = querry == "odd"
                ? number => number % 2 != 0
                : new Predicate<int>((number) => number % 2 == 0);
            var result = new List<int>();

            for (int number = bounds[0]; number <= bounds[1]; number++)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
