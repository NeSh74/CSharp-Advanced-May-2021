using System;
using System.Linq;

namespace _3_Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            //version 1
            //var input = console.readline()
            //    .split()
            //    .select(int.parse)
            //    .tolist();
            //console.writeline(input.min());
            //version 2
            //func<int[], int> minnumber = n => n.min();
            //int[] numbers = console.readline().split().select(int.parse).toarray();
            //console.writeline(minnumber(numbers));
            int number = Console.ReadLine().Split().Select(int.Parse).Min();
            Console.WriteLine(number);
        }
    }
}
