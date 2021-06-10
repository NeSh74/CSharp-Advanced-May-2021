using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_1_1_Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<string> firstSet = new HashSet<string>();
            HashSet<string> secondSet = new HashSet<string>();
            for (int i = 0; i < sizes[0] + sizes[1]; i++)
            {
                if (i >= sizes[0])
                {
                    secondSet.Add(Console.ReadLine());
                    continue;
                }
                firstSet.Add(Console.ReadLine());
            }
            foreach (var element in firstSet)
            {
                if (secondSet.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}
