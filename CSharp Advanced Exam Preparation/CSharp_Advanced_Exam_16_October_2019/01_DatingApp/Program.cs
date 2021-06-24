using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] malesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where( m=>m>0)
                .ToArray();
            int[] femalesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where( f=>f>0)
                .ToArray();

            Stack<int> males = new Stack<int>(malesInput);
            Queue<int> females = new Queue<int>(femalesInput);

            int matchesCount = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                int currentMale = males.Peek();
                int currentFemale = females.Peek();

                //if (currentMale <= 0)
                //{
                //    males.Pop();
                //    continue;
                //}
                //if (currentFemale <= 0)
                //{
                //    females.Dequeue();
                //    continue;
                //}

                if (currentMale % 25 == 0)
                {
                    males.Pop();
                    if (males.Count > 0)
                    {
                        males.Pop();
                    }
                    continue;
                }
                if (currentFemale % 25 == 0)
                {
                    females.Dequeue();
                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }
                    continue;
                }

                //Match
                if (currentMale == currentFemale)
                {
                    matchesCount++;
                    males.Pop();
                    females.Dequeue();
                }
                else
                {
                    females.Dequeue();
                    //Decrease by 2
                    males.Pop();
                    males.Push(currentMale - 2);
                }
            }

            Console.WriteLine($"Matches: {matchesCount}");

            string malesSting = males.Count > 0 ? String.Join(", ", males) : "none";
            Console.WriteLine($"Males left: {malesSting}");
            string femalesSting = females.Count > 0 ? String.Join(", ", females) : "none";
            Console.WriteLine($"Females left: {femalesSting}");
        }
    }
}
