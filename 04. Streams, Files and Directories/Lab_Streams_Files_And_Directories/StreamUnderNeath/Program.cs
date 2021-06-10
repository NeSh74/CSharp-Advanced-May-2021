using System;
using System.IO;

namespace StreamUnderNeath
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("../../../students.txt", FileMode.Open))
            {
                byte[] buffer = new byte[4096];
                //byte[] buffer = new byte[2];
                Console.WriteLine($"Stream Position:{stream.Position}");

                //for (int i = 0; i < 100; i++)
                for (int i = 0; i < stream .Length /2; i++)
                {
                    stream.Read(buffer, 0, 2);
                    using (FileStream writerStream = new FileStream($"students-{i}.txt",FileMode.Create,FileAccess.Write))
                    {
                        writerStream.Write(buffer,0,buffer.Length );
                    }
                    Console.Write($"{(char)buffer[0]}{(char)buffer[1]}");

                    //Console.WriteLine(string.Join(" ", buffer));
                }
                //stream.Read(buffer, 0,2);
                //Console.WriteLine($"{(char)buffer[0]}{(char)buffer[1]}");
                //Console.WriteLine((char)buffer[0]);
                //Console.WriteLine((char)buffer[1]);
                //Console.WriteLine(string.Join( " ", buffer));
                Console.WriteLine($"Stream Position:{stream.Position}");
            }
        }
    }
}
