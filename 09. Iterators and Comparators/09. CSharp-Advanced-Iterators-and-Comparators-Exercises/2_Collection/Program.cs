using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(" ").Skip(1).ToList();
            ListyIterator<string> list = new ListyIterator<string>(items);
            string command = Console.ReadLine();
            while (command != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "PrintAll":
                        //foreach (string item in list)
                        //{
                        //    Console.Write($"{item} ");
                        //}

                        //Console.WriteLine();
                        Console.WriteLine(string .Join( " ", list));
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
