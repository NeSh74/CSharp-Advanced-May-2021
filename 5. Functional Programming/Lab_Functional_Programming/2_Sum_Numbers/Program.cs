using System;
using System.Linq;

namespace _2_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, int> parser = int.Parse;
            PrintSumAndCount(
                int.Parse,
                a => a.Length,
                array => array.Sum()
            );

            static void PrintSumAndCount(Func<string, int> parser,
                Func<int[], int> countGetter,
                Func<int[], int> sumCalculater)
            {
                int[] array =
                                    Console.ReadLine()
                                        .Split(", ")
                                        .Select(parser)
                                        .ToArray();

                Console.WriteLine(countGetter(array));
                Console.WriteLine(sumCalculater(array));
            }
        }
    }
}
