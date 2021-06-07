using System;
using System.Linq;

namespace _12_TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();
            Func<string, int, bool> validator = (name, value) => name
                .ToCharArray()
                .Select(currChar => (int)currChar)
                .Sum() >= number;
            Func<string[], int, Func<string, int, bool>, string> foundname = (collection, value, func) =>
                collection.FirstOrDefault(name => func(name, value));
            Console.WriteLine(foundname(names, number, validator));
        }
    }
}
