using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DefiningClasses;

namespace _1_Define_A_Class_Person
{
    public class Family
    {
        private readonly HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
            => this.members.OrderByDescending(p => p.Age).FirstOrDefault();

        //{
        //    //explicity type
        //    Person person = this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        //    return person;
        //}
        public HashSet<Person> GetAllPeopleAbove30()
            => this.members.Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToHashSet();
    }
}
