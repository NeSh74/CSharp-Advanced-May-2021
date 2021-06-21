using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            List<int> sets = new List<int>();

            while (scarfs.Count > 0 && hats.Count > 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();
                int currentSet = 0;

                if (hat > scarf)
                {
                    currentSet = hat + scarf;
                    sets.Add(currentSet);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (scarf > hat)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    hat += 1;
                    hats.Pop();
                    hats.Push(hat);
                }
            }

            int maxSet = sets.Max();

            Console.WriteLine($"The most expensive set is: {maxSet}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
