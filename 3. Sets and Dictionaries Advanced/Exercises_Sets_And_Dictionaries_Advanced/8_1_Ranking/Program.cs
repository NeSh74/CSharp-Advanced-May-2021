using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_1_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }

                string[] info = input.Split(":");
                string contest = info[0];
                string password = info[1];
                contests.Add(contest, password);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of submissions")
                {
                    break;
                }
                string[] info = input.Split("=>");
                string contest = info[0];
                string password = info[1];
                string username = info[2];
                int points = int.Parse(info[3]);

                if (contests.Any(x => x.Key == contest  ))
                {
                    if (contests [contest ]==password )
                    {
                        if (!users .ContainsKey( username))
                        {
                        users.Add(username, new Dictionary<string, int>());
                        }

                        if (!users[username].ContainsKey(contest))
                        {
                            users[username].Add(contest, points);
                        }
                        else
                        {
                            if (users[username][contest] < points)
                            {
                                users[username][contest] = points;
                            }
                        }
                    }
                }
            }

            Dictionary<string, Dictionary<string, int>> bestInterns = users.OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine($"Best candidate is {bestInterns.First( ).Key} with total {bestInterns .First( ).Value .Values .Sum( )} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in users.OrderBy( x=>x.Key))
            {
                Console.WriteLine(user .Key );
                foreach (var contest in user.Value.OrderByDescending(x=>x.Value ))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest .Value}");
                }
            }
        }
    }
}
