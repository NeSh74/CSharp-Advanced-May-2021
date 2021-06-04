using System;
using System.Collections.Generic;

namespace _7_1_SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            var vip = new HashSet<string>();
            var regular = new HashSet<string>();

            while ((input = Console.ReadLine()) != "PARTY")
            {
                char x = input[0];

                if (Char.IsDigit(x))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }

            while ((input = Console.ReadLine()) != "END")
            {
                char x = input[0];

                if (Char.IsDigit(x))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
            }

            int noShow = vip.Count + regular.Count;
            Console.WriteLine(noShow);

            if (vip.Count > 0)
            {
                foreach (var guest in vip)
                {
                    Console.WriteLine(guest);
                }
            }

            if (regular.Count > 0)
            {
                foreach (var guest in regular)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
