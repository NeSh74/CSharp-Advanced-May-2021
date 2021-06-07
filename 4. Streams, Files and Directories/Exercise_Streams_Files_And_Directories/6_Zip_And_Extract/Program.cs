using System;
using System.IO.Compression;

namespace _6_Zip_And_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\lenovo\Desktop\Solution", @"C:\Users\lenovo\Desktop\Test\TestArchive.zip");
            ZipFile .ExtractToDirectory(@"C:\Users\lenovo\Desktop\Test\TestArchive.zip", @"C:\Users\lenovo\Desktop\Test");
        }
    }
}
