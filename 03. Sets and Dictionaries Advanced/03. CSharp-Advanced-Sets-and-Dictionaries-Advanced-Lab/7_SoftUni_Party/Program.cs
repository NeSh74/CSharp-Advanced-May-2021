using System;
using System.Collections.Generic;

namespace _7_SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            bool partyStarted = false;
            HashSet<string> vipPeople = new HashSet<string>();
            HashSet<string> regularPeople = new HashSet<string>();
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "PARTY")
                {
                    partyStarted = true;
                    continue;
                }

                if (partyStarted)
                {
                    if (IsVip(command))
                    {
                        vipPeople.Remove(command);
                    }
                    else
                    {
                        regularPeople.Remove(command);
                    }
                }
                else
                {
                    if (IsVip(command))
                    {
                        vipPeople.Add(command);
                    }
                    else
                    {
                        regularPeople.Add(command);
                    }
                }
            }

            Console.WriteLine(vipPeople.Count + regularPeople.Count);
            foreach (var person in vipPeople)
            {
                Console.WriteLine(person);
            }
            foreach (var person in regularPeople)
            {
                Console.WriteLine(person);
            }
        }

        private static bool IsVip(string number)
        {
            int num = 0;
            return int.TryParse(number.Substring(0, 1), out num);
        }
    }
}
