using System;
using System.Collections.Generic;

namespace _7_Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kidNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queue = new Queue<string>(kidNames);
            int n = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine("Removed " + queue.Dequeue());
            }

            Console.WriteLine("Last is " + queue.Dequeue());
        }
    }
}
