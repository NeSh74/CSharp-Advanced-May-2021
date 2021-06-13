using System;
using System.Collections.Generic;

namespace _6_1_1_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            FillWardrobe(wardrobe, lines);
            string[] clothesToFind = Console.ReadLine().Split();
            string color = clothesToFind[0];
            string cloth = clothesToFind[1];
            PrintResult(wardrobe, color, cloth);
        }

        static void PrintResult(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string cloth)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var clothing in kvp.Value)
                {
                    if (color == kvp.Key && cloth == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                }
            }
        }

        static Dictionary<string, Dictionary<string, int>> FillWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string currentColor = input[0];
                string[] clothes = input[1].Split(",");
                if (!wardrobe.ContainsKey(currentColor))
                {
                    wardrobe.Add(currentColor, new Dictionary<string, int>());
                }

                for (int cloth = 0; cloth < clothes.Length; cloth++)
                {
                    if (!wardrobe[currentColor].ContainsKey(clothes[cloth]))
                    {
                        wardrobe[currentColor].Add(clothes[cloth], 0);
                    }

                    wardrobe[currentColor][clothes[cloth]]++;
                }
            }
            return wardrobe;
        }
    }
}
