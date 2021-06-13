using System;
using System.Collections.Generic;

namespace _2_Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>();

            for (int i = 0; i < 1000; i++)
            {
                hashSet.Add($"{i}");
            }

            foreach (string item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
