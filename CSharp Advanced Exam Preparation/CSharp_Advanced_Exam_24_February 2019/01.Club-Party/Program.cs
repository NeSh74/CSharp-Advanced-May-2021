using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split());
            Queue<string> halls = new Queue<string>();
            int currentCapacity = capacity;
            List<int> resevations = new List<int>();
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int people;
                if (int.TryParse(current, out people))
                {
                    string firstHall = null;
                    //current is people
                    if (halls.Count > 0)
                    {
                        firstHall = halls.Peek();
                    }
                    currentCapacity -= people;
                    if (currentCapacity < 0)
                    {
                        if (firstHall !=null)
                        {
                            Console.WriteLine($"{firstHall} -> {string.Join(", ", resevations)}");
                        }
                        
                        if (halls .Count >0)
                        {
                            halls.Dequeue();
                        }
                        
                        //resevations .Clear();
                        resevations = new List<int>();
                        if (halls.Count > 0)
                        {
                            currentCapacity = capacity - people;
                            resevations.Add(people);
                        }
                        else
                        {
                            currentCapacity = capacity;
                        }
                    }
                    else
                    {
                        resevations.Add(people);
                    }
                }
                else
                {
                    //current is hall
                    halls.Enqueue(current);
                }
            }
        }
    }
}
