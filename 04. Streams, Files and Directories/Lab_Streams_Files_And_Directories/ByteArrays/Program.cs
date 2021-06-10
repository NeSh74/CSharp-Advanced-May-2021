using System;
using System.IO;
using System.Text;

namespace ByteArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hubav text. Ama mnogo hubav!";

            byte[] binarytext = Encoding.UTF8.GetBytes(text);

            Console.WriteLine(string .Join( " ", binarytext));
            using (FileStream writerStream = new FileStream($"../../../text.txt", FileMode.Create, FileAccess.Write))
            {
                writerStream.Write(binarytext, 0, binarytext.Length);
            }
        }
    }
}
