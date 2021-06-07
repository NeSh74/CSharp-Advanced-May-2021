using System;
using System.IO;

namespace _1_1_Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                string currentRow = reader.ReadLine();
                int row = 0;
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {


                    while (currentRow != null)
                    {
                        if (row % 2 != 0)
                        {
                            writer.WriteLine(currentRow);
                        }

                        currentRow = reader.ReadLine();
                        row++;
                    }
                }
            }
        }
    }
}
