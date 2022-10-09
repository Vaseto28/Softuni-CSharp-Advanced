using System;
using System.Linq;
using System.Collections.Generic;

class PeriodicTable
{
    public static void Main()
    {
        int chemicalsCount = int.Parse(Console.ReadLine());
        HashSet<string> chemicals = new HashSet<string>();

        for (int i = 0; i < chemicalsCount; i++)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < input.Length; j++)
            {
                chemicals.Add(input[j]);
            }
        }

        Console.WriteLine(String.Join(" ", chemicals.OrderBy(x => x)));
    }
}