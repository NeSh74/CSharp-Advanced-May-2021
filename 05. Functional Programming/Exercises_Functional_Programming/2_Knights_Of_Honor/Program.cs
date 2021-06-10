using System;
using System.Linq;

namespace _2_Knights_Of_Honor
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    Console.ReadLine()
        //        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        //        .ToList()
        //        .ForEach(name => Console.WriteLine("Sir " + name));
        //}
        =>
        Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToList()
            .ForEach(name => Console.WriteLine("Sir " + name));
    }
}
