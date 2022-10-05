using System;
using System.Linq;
using System.Collections.Generic;

class CountSameValuesInArray
{
    public static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> occurances = new Dictionary<string, int>();

        foreach (var num in nums)
        {
            if (!occurances.ContainsKey(num))
            {
                occurances.Add(num, 0);
            }
            occurances[num]++;
        }

        foreach (var kvp in occurances)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
        }
    }
}