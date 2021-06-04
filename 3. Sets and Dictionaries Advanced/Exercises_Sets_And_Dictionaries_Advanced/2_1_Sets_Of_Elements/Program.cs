using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_1_Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            FillSets(firstSet, lenghts[0]);
            FillSets(secondSet, lenghts[1]);
            CheckSets(firstSet, secondSet);
        }

        static void CheckSets(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            List<int> nums = new List<int>();
            foreach (int number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    nums.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        static HashSet<int> FillSets(HashSet<int> set, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
            return set;
        }
    }
}
