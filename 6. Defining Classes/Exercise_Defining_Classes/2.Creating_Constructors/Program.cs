using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();

            Person personTwo = new Person();

            Person presonThree = new Person();

            Console.WriteLine($"{personOne.Name} {personOne.Age}");
            Console.WriteLine($"{personTwo.Name} {personTwo.Age}");
            Console.WriteLine($"{presonThree.Name} {presonThree.Age}");
        }
    }
}