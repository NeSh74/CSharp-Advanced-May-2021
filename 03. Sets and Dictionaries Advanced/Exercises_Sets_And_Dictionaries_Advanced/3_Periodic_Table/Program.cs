using System;
using System.Collections.Generic;

namespace _3_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();
            FillSets(elements, lines);
            Console.WriteLine(string.Join(" ", elements));
        }

        private static SortedSet<string> FillSets(SortedSet<string> elements, int lines)
        {
            for (int line = 0; line < lines; line++)
            {
                string[] compaunds = Console.ReadLine().Split();
                for (int element = 0; element < compaunds.Length; element++)
                {
                    elements.Add(compaunds[element]);
                }
            }
            return elements;
        }
    }
}
