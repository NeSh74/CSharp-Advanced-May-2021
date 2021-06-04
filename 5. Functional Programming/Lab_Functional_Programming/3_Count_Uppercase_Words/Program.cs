using System;
using System.Linq;

namespace _3_Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, bool> filter = text => char.IsUpper(text[0]);
            //string text = Console.ReadLine();
            //string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //words = words.Where(filter).ToArray();

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            Predicate<string> predicate = str => str[0] == str.ToUpper()[0];

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => predicate(w))
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
