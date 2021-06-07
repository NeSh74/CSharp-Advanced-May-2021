using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _1_1_Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charToreplace = { '-', ',', '.', '!', '?' };
            using StreamReader reader = new StreamReader("text.txt");
            using StreamWriter writer = new StreamWriter("ActualResult.txt");
            using StreamWriter writer = new StreamWriter("../../../output.txt");
            int count = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }

                if (count % 2 == 0)
                {
                    line = ReplaceToAll(charToreplace, '@', line);
                    line = Reverse(line);
                    writer .WriteLine(line);
                    Console.WriteLine(line);

                }

                count++;
            }
        }

        static string Reverse(string line)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] word = line.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                stringBuilder.Append(word[word.Length - i - 1]);
                stringBuilder.Append(' ');
            }

            return stringBuilder.ToString().TrimEnd();
        }

        static string ReplaceToAll(char[] charToreplace, char c, string line)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (charToreplace.Contains(currentSymbol))
                {
                    sb.Append('@');
                }
                else
                {
                    sb.Append(currentSymbol);
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
