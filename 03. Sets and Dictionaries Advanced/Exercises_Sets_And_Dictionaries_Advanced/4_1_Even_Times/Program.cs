using System;
using System.Collections.Generic;

namespace _4_1_Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();
            FillDictionary(numbers, line);
            PrintResult(numbers);
        }

        private static void PrintResult(Dictionary<int, int> numbers)
        {
            int num = 0;
            foreach (KeyValuePair<int, int> kvp in numbers)
            {
                if (kvp.Value % 2 == 0)
                {
                    num = kvp.Key;
                }
            }

            Console.WriteLine(num);
        }

        static Dictionary<int, int> FillDictionary(Dictionary<int, int> numbers, int line)
        {
            for (int i = 0; i < line; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            return numbers;
        }
    }
}
