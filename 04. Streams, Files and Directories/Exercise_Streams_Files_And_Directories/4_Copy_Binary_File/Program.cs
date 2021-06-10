using System;
using System.IO;

namespace _4_Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BYTE_BUFFER = 4096;
            using (FileStream reader = new FileStream("./copyMe.png", FileMode.Open))

            using (FileStream writer = new FileStream("../../../copiePicture.png", FileMode.Create))

                while (reader .CanRead )
                {
                    byte[] buffer = new byte[BYTE_BUFFER];
                    int readBytes = reader.Read(buffer, 0, buffer.Length);
                    if (readBytes ==0)
                    {
                        break;
                    }

                    writer.Write(buffer, 0, readBytes);
                }
        }
    }
}
