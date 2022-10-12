using System;
using System.Linq;

class SuumNumbers
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        Console.WriteLine(nums.Count() + Environment.NewLine + nums.Sum());
    }
}