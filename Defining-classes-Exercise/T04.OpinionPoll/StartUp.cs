using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] properties = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = properties[0];
                int age = int.Parse(properties[1]);
                Person currPerson = new Person(name, age);

                if (currPerson.Age > 30)
                {
                    people.Add(currPerson);
                }
            }

            foreach (var person in people.OrderBy(x => x.Name).ToList())
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}

