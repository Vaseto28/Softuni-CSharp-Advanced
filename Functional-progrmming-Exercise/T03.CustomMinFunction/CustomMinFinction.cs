using System;
using System.Linq;

class CustomMinFinction
{
    public static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderBy(x => x)
            .ToArray();
        Console.WriteLine(nums[0]);
    }
}