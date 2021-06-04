using System;
using System.Collections.Generic;

namespace _3_1_Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            SortedDictionary<string, Dictionary<string, double>> shops =
                new SortedDictionary<string, Dictionary<string, double>>();

            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (shops.ContainsKey(tokens[0]) == false)
                {
                    shops[tokens[0]] = new Dictionary<string, double>();
                }
                shops[tokens[0]].Add(tokens[1], double.Parse(tokens[2]));
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop .Value )
                {
                    Console.WriteLine($"Product: {product .Key}, Price: {product .Value}");
                }
            }
        }
    }
}
