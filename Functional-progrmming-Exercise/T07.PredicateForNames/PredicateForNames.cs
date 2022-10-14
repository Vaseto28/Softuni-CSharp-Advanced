using System;
using System.Linq;
using System.Collections.Generic;

class PredicateForNames
{
    public static void Main()
    {
        int nameLength = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        Predicate<string> checker = x => x.Length <= nameLength;
        names = names.Where(x => checker(x)).ToList();
        Console.WriteLine(String.Join(Environment.NewLine, names));
    }
}