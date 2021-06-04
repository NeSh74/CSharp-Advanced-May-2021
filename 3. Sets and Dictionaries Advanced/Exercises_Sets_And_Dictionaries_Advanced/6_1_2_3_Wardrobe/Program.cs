using System;
using System.Collections.Generic;

namespace _6_1_2_3_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes =
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    string garment = input[j];

                    if (!clothes[color].ContainsKey(garment))
                    {
                        clothes[color].Add(garment, 0);
                    }

                    clothes[color][garment]++;
                }
            }

            string[] searchedTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string searchedColor = searchedTokens[0];
            string searchedGarment = searchedTokens[1];

            foreach (var kvp in clothes)
            {

                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var garment in kvp.Value)
                {
                    if (kvp.Key == searchedColor)
                    {

                        if (garment.Key == searchedGarment)
                        {
                            Console.WriteLine($"* {garment.Key} - {garment.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {garment.Key} - {garment.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value}");
                    }
                }
            }
        }
    }
}
