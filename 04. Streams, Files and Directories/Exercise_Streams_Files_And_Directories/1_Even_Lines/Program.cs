using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1_Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line=reader.ReadLine();
                int lineCounter = 0;
                while (line!=null)
                {
                    //line = line.Replace('-', '@');
                    //line = line.Replace(',', '@');
                    //line = line.Replace('.', '@');
                    //line = line.Replace('!', '@');
                    //line = line.Replace('?', '@');

                    if (lineCounter %2==0)
                    {
                        Regex pattern = new Regex("[-,.!?]");
                        line=pattern.Replace(line,"@");
                        var array = line.Split().ToArray().Reverse();
                        Console.WriteLine(string .Join( " ",array ));
                    }

                    lineCounter++;
                    line = reader.ReadLine();
                }
            }

        }
    }
}
