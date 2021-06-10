using System;
using System.Diagnostics;

namespace _5_Filter_By_Age
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            Func<Person, bool> condition = GetAgeCondition(filter, filterAge);
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{person.Name } - {person.Age}");
            //}
            //PrintPeole(people, p => p.Age > 23 /*filterAge*/); 

            Func<Person, string> formatter = GetFormatter(Console.ReadLine());

            PrintPeole(people, condition, formatter);
        }

        static Func<Person, string> GetFormatter(string format)
        {
            switch (format)
            {
                case "name":
                    return p => $"{p.Name}";
                case "age":
                    return p => $"{p.Age}";
                case "name age":
                    return p => $"{p.Name} - {p.Age}";
                default:
                    return null;
            }
        }
        static Func<Person, bool> GetAgeCondition(string filter, int filterAge)
        {
            switch (filter)
            {
                case "younger":
                    return p => p.Age < filterAge;
                case "older":
                    return p => p.Age >= filterAge;
                default:
                    return null;
            }
        }

        static void PrintPeole(Person[] people, Func<Person, bool> condition, Func<Person, string> formatter)
        {
            foreach (var person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine(formatter(person));
                }
            }
        }
    }
}
