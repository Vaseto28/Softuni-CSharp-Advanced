using System;
using System.Collections.Generic;

class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string element = Console.ReadLine();
            list.Add(element);
        }

        string elementForComparison = Console.ReadLine();
        int value = 0;
        foreach (var ch in elementForComparison)
        {
            value += ch;
        }

        int count = 0;
        foreach (var stringElement in list)
        {
            int currCharValue = 0;
            foreach (var ch in stringElement)
            {
                currCharValue += ch;
            }

            if (currCharValue >= value)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}