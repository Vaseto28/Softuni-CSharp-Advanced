using System;
using System.Linq;
using System.Collections.Generic;

class ReverseAndExcluse
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Reverse()
            .ToList();

        int number = int.Parse(Console.ReadLine());
        Predicate<int> checker = x => x % number != 0;

        numbers = numbers.Where(x => checker(x)).ToList();

        Console.WriteLine(String.Join(" ", numbers));
    }
}