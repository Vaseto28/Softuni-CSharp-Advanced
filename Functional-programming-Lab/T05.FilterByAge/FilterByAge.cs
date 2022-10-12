using System;
using System.Linq;
using System.Collections.Generic;

class FilterByAge
{
    public static void Main()
    {
        List<Person> people = ReadPeople();

        string condition = Console.ReadLine();
        int threshold = int.Parse(Console.ReadLine());
        string format = Console.ReadLine();

        Func<Person, bool> filter = CreatePersonFilter(condition, threshold);
        List<Person> filteredPeople = people.Where(filter).ToList();

        Action<Person> print = CreatePersonPrint(format);
        foreach (var person in filteredPeople)
        {
            print(person);
        }
    }

    private static Action<Person> CreatePersonPrint(string? format)
    {
        if (format == "name age")
            return x => Console.WriteLine($"{x.Name} - {x.Age}");
        if (format == "name")
            return x => Console.WriteLine($"{x.Name}");
        if (format == "age")
            return x => Console.WriteLine($"{x.Age}");

        throw new ArgumentException($"Invalid format: {format}");
    }

    private static Func<Person, bool> CreatePersonFilter(string? condition, int threshold)
    {
        if (condition == "older")
            return x => x.Age >= threshold;
        if (condition == "younger")
            return x => x.Age < threshold;

        throw new ArgumentException($"Invalid condition {condition} or threshold {threshold}");
    }

    private static List<Person> ReadPeople()
    {
        List<Person> people = new List<Person>();
        int peopleCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < peopleCount; i++)
        {
            string[] tokens = Console.ReadLine().Split(", ");
            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            Person currPerson = new Person(name, age);
            people.Add(currPerson);
        }

        return people;
    }
}

class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }
}