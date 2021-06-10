using System;
using System.IO;

namespace StreamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("../../../input.txt"); //I variant

            //StreamReader reader = new StreamReader(@"C:\Users\lenovo\source\repos\Lab_Streams_Files_And_Directories\StreamsAndFiles\input.txt");

            //string line = reader.ReadLine();

            //Console.WriteLine(line);

            //reader.Close();

            //StreamWriter writer = new StreamWriter(@"C:\Users\lenovo\source\repos\Lab_Streams_Files_And_Directories\StreamsAndFiles\input.txt",true);

            //writer .WriteLine("Files are cool");
            //writer.Close();

            using (StreamReader reader =
                new StreamReader(
                    @"C:\Users\lenovo\source\repos\Lab_Streams_Files_And_Directories\StreamsAndFiles\input.txt"))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);

            }
        }
    }
}

