using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //var scale = new EqualityScale<int>(3, 3);
            var scale = new EqualityScale<string >("Pesho", "Pesho");
            Console.WriteLine(scale.AreEqual());
        }
    }
}
