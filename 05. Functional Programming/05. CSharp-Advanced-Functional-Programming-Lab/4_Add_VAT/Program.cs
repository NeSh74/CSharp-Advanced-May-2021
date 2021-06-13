using System;
using System.Linq;

namespace _4_Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            //    decimal[] numbers = Console.ReadLine()
            //        .Split(", ")
            //        .Select(decimal.Parse)
            //        .Select(number => number * 1.2m)
            //        .ToArray();
            //    //numbers = Select(numbers, number => number * 5);
            //    foreach (var number in numbers)
            //    {
            //        Console.WriteLine($"{number:F2}");
            //    }
            //}

            //static decimal[] Select(decimal[] array, Func<decimal, decimal> transform)
            //{
            //    decimal[] newArray = new Decimal[array.Length];
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        newArray[i] = transform(array[i]);
            //    }
            //    return newArray;
            //}
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(p => p * 1.2m)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p:F2}"));
        }
    }
}
