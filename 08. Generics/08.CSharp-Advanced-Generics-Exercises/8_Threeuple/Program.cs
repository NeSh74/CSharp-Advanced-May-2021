using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(" ");
            string fullname = $"{firstTupleData[0]} {firstTupleData[1]}";
            List<string> townRawdata = firstTupleData.ToList().Skip(3).ToList();
            string town = string.Join(" ", townRawdata);

            Threeuple<string, string, string> firstThreeuple =
                new Threeuple<string, string, string>(fullname, firstTupleData[2], town);


            string[] secondTupleData = Console.ReadLine().Split(" ");
            bool drunk = secondTupleData[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> secondThreeuple =
                new Threeuple<string, int, bool>(secondTupleData[0], int.Parse(secondTupleData[1]), drunk);


            string[] thirdTupleData = Console.ReadLine().Split(" ");
            Threeuple<string, double, string> thirdThreeuple =
                new Threeuple<string, double, string>(thirdTupleData[0], double.Parse(thirdTupleData[1]),
                    thirdTupleData[2]);


            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
