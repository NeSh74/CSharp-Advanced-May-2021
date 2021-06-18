using System;

namespace _5_Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("AA", 20, "DD");
            Person person2 = new Person("AA", 20, "BB");

            Console.WriteLine(person1 .CompareTo( person2 ));
        }
    }
}
