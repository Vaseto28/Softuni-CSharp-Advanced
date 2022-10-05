using System;
using System.Linq;
using System.Collections.Generic;

class Largest3Numbers
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            .ToList();
        Console.WriteLine(String.Join(" ", nums));
    }
}