using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_1_Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = Console.ReadLine().Split().ToList();
            input = input.Where(x => x.Length <= n).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
