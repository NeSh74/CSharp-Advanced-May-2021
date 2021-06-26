﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dish = new Dictionary<int, string>()
            {
                { 150, "Dipping sauce" },
                { 250, "Green salad" },
                { 300, "Chocolate cake" },
                { 400, "Lobster" }
            };

            Dictionary<string, int> cookedDish = new Dictionary<string, int>()
            {
                { "Dipping sauce", 0 },
                { "Green salad", 0 },
                { "Chocolate cake", 0 },
                { "Lobster", 0 }
            };

            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> freshnessLevelValues = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            while (ingredients.Any() && freshnessLevelValues.Any())
            {
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int sum = ingredients.Peek() * freshnessLevelValues.Peek();

                if (dish.ContainsKey(sum))
                {
                    ingredients.Dequeue();
                    freshnessLevelValues.Pop();

                    cookedDish[dish[sum]]++;

                    continue;
                }

                freshnessLevelValues.Pop();

                ingredients.Enqueue(ingredients.Dequeue() + 5);
            }

            Console.WriteLine(cookedDish.All(x => x.Value > 0) ?
                "Applause! The judges are fascinated by your dishes!" :
                "You were voted off. Better luck next year.");

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var dishes in cookedDish.Where(x => x.Value > 0).OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {dishes.Key} --> {dishes.Value}");
            }
        }
    }
}
