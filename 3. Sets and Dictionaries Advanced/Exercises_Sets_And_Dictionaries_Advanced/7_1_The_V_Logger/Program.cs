using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_1_The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> vlogers = new Dictionary<string, List<string>>();
            Dictionary<string, int[]> userNumberOfFollowers = new Dictionary<string, int[]>();
            string inputLines = Console.ReadLine();

            while (inputLines?.ToLower() != "statistics")
            {
                string[] tokens = inputLines.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string command = tokens[1];
                if (command?.ToLower() == "joined")
                {
                    if (!vlogers.ContainsKey(username))
                    {
                        vlogers[username] = new List<string>();
                        userNumberOfFollowers[username] = new int[2];
                    }
                }
                else if (command?.ToLower() == "followed")
                {
                    string userToFollow = tokens[2];
                    if (vlogers.ContainsKey(username) && vlogers.ContainsKey(userToFollow))
                    {
                        if (!vlogers[userToFollow].Contains(username) && username != userToFollow)
                        {
                            vlogers[userToFollow].Add(username);
                            userNumberOfFollowers[userToFollow][0]++;
                            userNumberOfFollowers[username][1]++;
                        }
                    }

                }
                inputLines = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            Dictionary<string, int[]> orderUsersAndFollowers = userNumberOfFollowers.OrderByDescending(v => v.Value[0])
                .ThenBy(v => v.Value[1]).ToDictionary(k => k.Key, v => v.Value);
            int count = 1;
            string usersToRemove = "";
            foreach (KeyValuePair<string, int[]> kvp in orderUsersAndFollowers)
            {
                usersToRemove = kvp.Key;
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;
                if (vlogers[kvp.Key].Count > 0)
                {
                    foreach (string follower in vlogers[kvp.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                break;
            }

            orderUsersAndFollowers.Remove(usersToRemove);
            foreach (KeyValuePair<string, int[]> kvp in orderUsersAndFollowers)
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;
            }
        }
    }
}
