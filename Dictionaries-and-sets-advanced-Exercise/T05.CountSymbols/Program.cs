using System;
using System.Linq;
using System.Collections.Generic;

class CountSymbol
{
    public static void Main()
    {
        string inputText = Console.ReadLine();
        Dictionary<char, int> occurances = new Dictionary<char, int>();
        for (int i = 0; i < inputText.Length; i++)
        {
            char currElement = inputText[i];
            if (!occurances.ContainsKey(currElement))
            {
                occurances.Add(currElement, 0);
            }
            occurances[currElement]++;
        }

        foreach (var kvp in occurances.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}