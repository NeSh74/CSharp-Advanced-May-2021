using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
        : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
        :this(age)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Can't be below 0");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"{this .Name} - {this .Age}";
        }
    }
}
