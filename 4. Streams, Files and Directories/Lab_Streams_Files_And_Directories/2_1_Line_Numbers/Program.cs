using System;
using System.IO;

namespace _2_1_Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    string line = reader.ReadLine();
                    int row = 1; 
                    while (line!=null)
                    {
                        writer .WriteLine($"{row}. {line}");
                        row++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
