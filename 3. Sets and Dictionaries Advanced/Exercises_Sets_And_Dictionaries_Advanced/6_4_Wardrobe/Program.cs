using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_4_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> colorClothesAndCount = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] wardrobeArgs = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = wardrobeArgs[0];
                string[] clothes = string.Join(",", wardrobeArgs.Skip(1)).Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (colorClothesAndCount.ContainsKey(color) == false)
                {
                    colorClothesAndCount.Add(color, new Dictionary<string, int>());
                }
                foreach (var cloth in clothes)
                {
                    if (colorClothesAndCount[color].ContainsKey(cloth) == false)
                    {
                        colorClothesAndCount[color].Add(cloth, 0);
                    }
                    colorClothesAndCount[color][cloth]++;
                }
            }
            string[] searchedCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var color in colorClothesAndCount)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    string result = $"* {cloth.Key} - {cloth.Value} ";
                    if (color.Key == searchedCloth[0] && cloth.Key == searchedCloth[1])
                    {
                        result += ("(found!)");
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
