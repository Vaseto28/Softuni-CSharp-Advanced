using System;
using System.Linq;
using System.Collections.Generic;

class FindEvensOrOdds
{
    public static void Main()
    {
        int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int start = bounds[0];
        int end = bounds[1];
        List<int> numbers = GetNumbers(start, end);

        string condition = Console.ReadLine();
        Predicate<int> checker = CreateFormating(condition);
        Console.WriteLine(String.Join(" ", numbers.Where(x => checker(x))));
    }

    private static Predicate<int> CreateFormating(string? condition)
    {
        if (condition == "odd")
            return x => x % 2 != 0;
        if (condition == "even")
            return x => x % 2 == 0;

        throw new ArgumentException($"Invalid condition: {condition}");
    }

    private static List<int> GetNumbers(int start, int end)
    {
        List<int> numbers = new List<int>();

        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }

        return numbers;
    }
}