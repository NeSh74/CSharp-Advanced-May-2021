using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int[]> asdw = new Dictionary<string, int[]>();
            //Dictionary<string, SortedSet<string>[]> asd = new Dictionary<string, SortedSet<string>[]>();
            //var userdata = new[] {new SortedSet<string >(), new SortedSet<string>() };
            //asd.Add("User one", userdata);
            //SortedSet<string>[] data = asd["User one"];
            //asd["User one"][0].Add("User two" );

            Dictionary<string, Dictionary<string, SortedSet<string>>> app =
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            //app.Add("User one", new Dictionary<string, SortedSet<string>>());
            //app["User one"].Add("following", new SortedSet<string>());
            //app["User one"].Add("folowers", new SortedSet<string>());

            string commandInput = Console.ReadLine();

            while (commandInput != "Statistics")
            {
                string[] commandData = commandInput.Split(" ");
                string vloggerName = commandData[0];
                string command = commandData[1];
                if (command == "joined")
                {
                    if (!app.ContainsKey(vloggerName))
                    {
                        app.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        app[vloggerName].Add("following", new SortedSet<string>());
                        app[vloggerName].Add("followers", new SortedSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string vloggerTwoName = commandData[2];
                    if (app.ContainsKey(vloggerName) && app.ContainsKey(vloggerTwoName) &&
                        vloggerName != vloggerTwoName)
                    {
                        app[vloggerName]["following"].Add(vloggerTwoName);
                        app[vloggerTwoName]["followers"].Add(vloggerName);
                    }
                }

                commandInput = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, SortedSet<string>>> sortedDataApp = app.OrderByDescending(kvp => kvp.Value["followers"].Count)
                 .ThenBy(kvp => kvp.Value["following"].Count)
                 .ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine($"The V-Logger has a total of {app.Count} vloggers in its logs.");
            int counter = 0;
            foreach (KeyValuePair<string, Dictionary<string, SortedSet<string>>> item in sortedDataApp)
            {
                Console.WriteLine($"{++counter}. {item.Key} : {item.Value["followers"].Count } followers, {item.Value["following"].Count } following");
                if (counter == 1)
                {
                    foreach (string follower in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }
}
