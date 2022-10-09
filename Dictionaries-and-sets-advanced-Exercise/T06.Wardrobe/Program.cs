using System;
using System.Linq;
using System.Collections.Generic;

class Wardrobe
{
    public static void Main()
    {
        int clothesCount = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < clothesCount; i++)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            string colour = input[0];
            if (!clothes.ContainsKey(colour))
            {
                clothes.Add(colour, new Dictionary<string, int>());
            }

            string[] currClothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> currClothesDict = new Dictionary<string, int>();
            for (int j = 0; j < currClothes.Length; j++)
            {
                string currClothe = currClothes[j];
                if (!currClothesDict.ContainsKey(currClothe))
                {
                    currClothesDict.Add(currClothe, 0);
                }
                currClothesDict[currClothe]++;
            }

            foreach (var kvp in currClothesDict)
            {
                if (!clothes[colour].ContainsKey(kvp.Key))
                {
                    clothes[colour].Add(kvp.Key, 0);
                }
                clothes[colour][kvp.Key] += kvp.Value;
            }
        }

        string[] clothesToSearch = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string colourToSearch = clothesToSearch[0];
        string clotheToSearch = clothesToSearch[1];

        foreach (var kvp in clothes)
        {
            string currColour = kvp.Key;
            Console.WriteLine($"{kvp.Key} clothes:");
            foreach (var kvp1 in kvp.Value)
            {
                if (currColour == colourToSearch && kvp1.Key == clotheToSearch)
                {
                    Console.WriteLine($"* {kvp1.Key} - {kvp1.Value} (found!)");
                    continue;
                }
                Console.WriteLine($"* {kvp1.Key} - {kvp1.Value}");
            }
        }
    }
}