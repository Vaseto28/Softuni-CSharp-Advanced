using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> Members { get; set; }

        public Family(List<Person> members)
        {
            this.Members = members;
        }

        public void AddPerson(Person person)
        {
            Members.Add(person);
        }

        public Person GetTheOldestPerson()
        {
            this.Members = this.Members.OrderByDescending(x => x.Age).ToList();
            return Members[0];
        }
    }
}

