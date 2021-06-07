using System;
using System.Linq;

namespace _1_Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> names = (name) =>
            {
                Console.WriteLine(name);
            };
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(names);
            //Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(new Action<string>(name => Console.WriteLine(name)));
        }
    }
}
