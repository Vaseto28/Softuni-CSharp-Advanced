using System;
using System.Linq;
using System.Collections.Generic;

class CitiesByContinentAndCountry
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, List<string>>> world = new Dictionary<string, Dictionary<string, List<string>>>();
        int commandsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < commandsCount; i++)
        {
            string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string continent = info[0];
            string country = info[1];
            string city = info[2];

            if (!world.ContainsKey(continent))
            {
                world.Add(continent, new Dictionary<string, List<string>>());
            }
            if (!world[continent].ContainsKey(country))
            {
                world[continent].Add(country, new List<string>());
            }
            world[continent][country].Add(city);
        }

        foreach (var kvp in world)
        {
            Console.WriteLine($"{kvp.Key}: ");
            foreach (var kvp2 in kvp.Value)
            {
                Console.WriteLine($"{kvp2.Key} -> {String.Join(", ", kvp2.Value)}");
            }
        }
    }
}