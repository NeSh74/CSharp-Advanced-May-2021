using System;
using System.Collections.Generic;

namespace _5_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            FillDictionary(symbols, input);
            PrintResult(symbols);
        }

        private static void PrintResult(SortedDictionary<char, int> symbols)
        {
            foreach (KeyValuePair<char, int> kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }

        static SortedDictionary<char, int> FillDictionary(SortedDictionary<char, int> symbols, string input)
        {
            foreach (char symbol in input)
            {
                if (!symbols.ContainsKey(symbol))
                {
                    symbols.Add(symbol, 0);
                }

                symbols[symbol]++;
            }

            return symbols;
        }
    }
}
