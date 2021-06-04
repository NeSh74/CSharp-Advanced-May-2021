using System;
using System.Collections.Generic;

namespace _1_Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> collection = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                collection.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, collection));
        }
    }
}
