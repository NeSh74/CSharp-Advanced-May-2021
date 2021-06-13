using System;
using System.IO;
using System.Threading.Tasks;

namespace _1_Odd_Lines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader str = new StreamReader("TextFile1.txt"))
            {
                int currentLine = 0;
                string line = await str.ReadLineAsync();

                while (line != null)
                {
                    if (currentLine % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    currentLine++;
                    line = await str.ReadLineAsync();
                }
            }
        }
    }
}
