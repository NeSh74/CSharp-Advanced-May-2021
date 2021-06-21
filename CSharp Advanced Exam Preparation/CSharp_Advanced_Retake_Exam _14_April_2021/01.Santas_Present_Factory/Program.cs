using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Santas_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var inpu1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inpu2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> materialsForCrafiting = new Stack<int>(inpu1);
            Queue<int> magicLevelValues = new Queue<int>(inpu2);

            Dictionary<int, string> presentMagicLevel = new Dictionary<int, string>
            {
                {150, "Doll" },
                {250, "Wooden train" },
                {300, "Teddy bear" },
                {400, "Bicycle" }
            };
            //Dictionary<string, int> presentsMade = new Dictionary<string, int>(); 
            SortedDictionary<string, int> presentsMade = new SortedDictionary<string, int>();

            while (materialsForCrafiting.Count > 0 && magicLevelValues.Count > 0)
            {
                int magicLevel = materialsForCrafiting.Peek() * magicLevelValues.Peek();
                if (presentMagicLevel.ContainsKey(magicLevel))
                {
                    if (!presentsMade.ContainsKey(presentMagicLevel[magicLevel]))
                    {
                        presentsMade.Add(presentMagicLevel[magicLevel], 0);
                    }

                    presentsMade[presentMagicLevel[magicLevel]]++;
                    materialsForCrafiting.Pop();
                    magicLevelValues.Dequeue();
                }
                else
                {
                    if (magicLevel < 0)
                    {
                        int sum = materialsForCrafiting.Peek() + magicLevelValues.Peek();
                        materialsForCrafiting.Pop();
                        magicLevelValues.Dequeue();
                        materialsForCrafiting.Push(sum);
                    }
                    else if (magicLevel > 0)
                    {
                        int material = materialsForCrafiting.Peek() + 15;
                        materialsForCrafiting.Pop();
                        magicLevelValues.Dequeue();
                        materialsForCrafiting.Push(material);
                    }
                    else if (magicLevel == 0)
                    {
                        if (materialsForCrafiting.Peek() == 0)
                        {
                            materialsForCrafiting.Pop();
                        }

                        if (magicLevelValues.Peek() == 0)
                        {
                            magicLevelValues.Dequeue();
                        }
                    }
                }
            }

            if ((presentsMade .ContainsKey("Doll" )&& presentsMade .ContainsKey("Wooden train"))
            ||( presentsMade .ContainsKey("Teddy bear") && presentsMade .ContainsKey("Bicycle")))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materialsForCrafiting .Count >0)
            {
                Console.WriteLine("Materials left: "+string.Join( ", ",materialsForCrafiting )); 
            }

            if (magicLevelValues .Count >0)
            {
                Console.WriteLine("Magic left: " + string.Join(", ", magicLevelValues));
            }

            //foreach (var present in presentsMade.OrderBy( x=>x.Key))
            foreach (var present in presentsMade)
            {
                Console.WriteLine($"{present .Key }: {present .Value }");
            }
        }
    }
}
