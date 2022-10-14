using System;
using System.Linq;
using System.Collections.Generic;

class ListOfPredicates
{
    public static void Main()
    {
        int bound = int.Parse(Console.ReadLine());
        List<int> numbers = ReadNumbers(bound);

        List<int> deviders = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        foreach (var devider in deviders)
        {
            Predicate<int> checker = x => x % devider == 0;
            numbers = numbers.Where(x => checker(x)).ToList();
        }

        Console.WriteLine(String.Join(" ", numbers));
    }

    private static List<int> ReadNumbers(int bound)
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= bound; i++)
        {
            numbers.Add(i);
        }

        return numbers;
    }
}