using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            //wardrobe.Add("blue", new Dictionary<string, int>());
            //Dictionary<string, int> wardrobeColorValue = wardrobe["blue"];
            //wardrobeColorValue.Add("dress", 1);
            //wardrobe["blue"].Add("dress", 1);
            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine()
                    .Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = inputData[0];
                string[] allClothes = inputData.Skip(1).ToArray();
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                //Dictionary<string, int> currentColorClothes = wardrobe[color];

                foreach (string item in allClothes)
                {
                    //if (!currentColorClothes.ContainsKey(item))
                    if (!wardrobe [color].ContainsKey(item))
                    {
                        //currentColorClothes.Add(item, 0);
                        wardrobe[color].Add(item, 0);
                    }

                    //currentColorClothes[item]++;
                    wardrobe[color][item]++;
                }
            }

            string[] searchData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //foreach (KeyValuePair<string, Dictionary<string, int>> colorDta in wardrobe)
            foreach ((string color, Dictionary<string, int> colorData) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach ((string clothes, int count) in colorData)
                {
                    if (searchData[0] == color && searchData[1] == clothes)
                    {
                        Console.WriteLine($"* {clothes} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes} - {count}");
                    }
                }
            }
        }
    }
}
