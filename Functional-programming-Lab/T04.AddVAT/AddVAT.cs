using System;
using System.Linq;

class AddVAT
{
    public static void Main()
    {
        decimal[] numbers = Console.ReadLine().Split(", ").Select(decimal.Parse).Select(num => num * 1.20m).ToArray();
        foreach (var num in numbers)
        {
            Console.WriteLine($"{num:f2}");
        }
    }
}