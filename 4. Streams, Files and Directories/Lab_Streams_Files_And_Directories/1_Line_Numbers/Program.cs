using System;
using System.IO;
using System.Threading.Tasks;

namespace _2_Line_Numbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader str = new StreamReader("TextFile1.txt"))
            { 
                string line = await str.ReadLineAsync();
                using (StreamWriter wrt = new StreamWriter("Output.txt"))
                {
                    int count = 1;
                    while (line != null)
                    {
                        await wrt.WriteLineAsync($"{count}. {line}");
                        count++;
                        line = await str.ReadLineAsync();
                    }
                }
            }
        }
    }
}
