using System;
using System.Collections.Generic;

namespace _6_Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>();
            foreach (string song in songs)
            {
                queue.Enqueue(song);
            }

            while (queue.Count > 0)
            {
                string cmd = Console.ReadLine();
                if (cmd == "Play")
                {
                    queue.Dequeue();
                }
                else if (cmd == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                {
                    int idx = cmd.IndexOf(' ');
                    string song = cmd.Substring(idx + 1);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
