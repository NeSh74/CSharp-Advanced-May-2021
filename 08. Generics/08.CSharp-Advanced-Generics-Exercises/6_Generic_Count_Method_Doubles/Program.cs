using System;
using System.Collections.Generic;

namespace _6_Generic_Count_Method_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            double value = double.Parse(Console.ReadLine());
            Box<double> comparableBox = new Box<double>(value);
            int count = GetGreaterThanCount(boxes, comparableBox);
            Console.WriteLine(count);
        }

        private static int GetGreaterThanCount<T>(List<Box<T>> boxes, Box<T> box)
            where T : IComparable
        {
            int count = 0;
            foreach (Box<T> item in boxes)
            {
                //int compare = item.Value.CompareTo(box.Value);
                int compare = item.CompareTo(box);
                if (compare > 0)
                {
                    count++;
                }
            }

            return count;
        }

        private static void SwapIndexes<T>(List<Box<T>> boxes, int firstIndex, int secondIndex)
            where T : IComparable
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
    }
}
