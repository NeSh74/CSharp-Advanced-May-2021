using System;
using System.Collections.Generic;
using _1_Define_A_Class_Person;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ////T1
            //string name = "Pesho";
            //int age = 24;
            //Person pesho = new Person()
            //{
            //    Name = name,
            //    Age= age
            //};
            //Console.WriteLine($"{pesho .Name} - {pesho .Age}");
            ////T2
            //Console.WriteLine("--------------------------------");
            //var noName = new Person();
            //Console.WriteLine($"NoNameGuy: {noName .Name} - {noName .Age}");
            //var george = new Person(24);
            //Console.WriteLine($"GeorgeYears: {george .Name} - {george .Age}");
            //var ivan = new Person("Ivan", 27);
            //Console.WriteLine($"Ivan: {ivan .Name} - {ivan .Age}");

            //T3
            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                var cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArg[0];
                int age = int.Parse(cmdArg[1]);
                var person = new Person(name, age);
                family.AddMember(person);
            }
            //T3
            //Console.WriteLine(family .GetOldestMember() );
            HashSet<Person> personAbove30 = family.GetAllPeopleAbove30();
            Console.WriteLine(string.Join(Environment.NewLine, personAbove30));
        }
    }
}
