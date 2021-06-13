using System;
using System.Linq;

namespace _7_Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Predicate<string> filter = name => name.Length <= lenght;
            foreach (var name in names.Where(name => filter(name)))
            {
                Console.WriteLine(name);
            }
            //Action<string[]> printNames = name =>
            //{
            //    Predicate<string> filter = name => name.Length <= lenght;
            //    foreach (string currName in names.Where(name => filter(name)))
            //    {
            //        Console.WriteLine(currName);
            //    }
            //};
            //printNames(names);
        }
    }
}
