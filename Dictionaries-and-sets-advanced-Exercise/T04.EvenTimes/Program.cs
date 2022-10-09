using System;
using System.Linq;
using System.Collections.Generic;

class EvenTimes
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int currNum = int.Parse(Console.ReadLine());
            if (!numbers.ContainsKey(currNum))
            {
                numbers.Add(currNum, 1);
            }
            numbers[currNum]++;

        }

        foreach (var kvp in numbers)
        {
            if (numbers[kvp.Key] % 2 != 0)
            {
                Console.WriteLine(kvp.Key);
                break;
            }
        }
    }
}