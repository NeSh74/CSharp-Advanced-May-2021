using System;
using System.Linq;

namespace _6_Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divisibleNum = int.Parse(Console.ReadLine());
            Predicate<int> filter = numbers => numbers % divisibleNum != 0;
            //Console.WriteLine(string.Join(" ", numbers.Reverse().Where(x => filter(x))));
            Action<int[]> printer = number => Console.WriteLine(string.Join(" ", number.Reverse().Where(x => filter(x))));
            printer(numbers);
        }
    }
}
