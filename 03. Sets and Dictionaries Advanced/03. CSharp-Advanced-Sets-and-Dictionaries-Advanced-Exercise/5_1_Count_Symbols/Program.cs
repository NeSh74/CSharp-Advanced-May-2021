using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_1_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> queue = new Queue<char>(Console.ReadLine());
            Dictionary<char, int> pairs = new Dictionary<char, int>();

            while (queue.Count > 0)
            {
                if (pairs.ContainsKey(queue.Peek()) == false)
                {
                    pairs.Add(queue.Peek(), 0);
                }
                pairs[queue.Dequeue()]++;
            }

            foreach (var item in pairs.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
