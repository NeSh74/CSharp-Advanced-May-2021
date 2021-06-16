using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var list = new List<double>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = double.Parse( Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<double>(list);
            var elementToCompare = double.Parse(Console.ReadLine());
            var count = box.CountOfGreaterElements(list, elementToCompare);
            Console.WriteLine(count);
        }
    }
}
