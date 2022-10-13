using System;
using System.Linq;

class KnightsOfHonor
{
    public static void Main()
    {
        string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Action<string> print = x => Console.WriteLine($"Sir {x}");
        foreach (var name in names)
            print(name);
    }
}