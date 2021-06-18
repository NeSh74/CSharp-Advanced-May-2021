using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Comparing_Objects
{
    public class Person : IComparable<Person>, IComparable
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }


        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            if (this.Town.CompareTo(other.Town) != 0)
            {
                return this.Town.CompareTo(other.Town);
            }

            return 0;
        }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            return obj is Person other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Person)}");
        }
    }
}
