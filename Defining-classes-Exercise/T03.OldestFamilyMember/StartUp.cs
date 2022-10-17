using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> familyMembers = new List<Person>();
            Family members = new Family(familyMembers);
            for (int i = 0; i < n; i++)
            {
                string[] properties = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = properties[0];
                int age = int.Parse(properties[1]);
                Person currPerson = new Person(name, age);

                members.AddPerson(currPerson);
            }

            Person oldestPerson = members.GetTheOldestPerson();
            Console.WriteLine(oldestPerson.Name + " " + oldestPerson.Age);
        }
    }
}