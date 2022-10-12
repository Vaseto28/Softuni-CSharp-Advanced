using System;
using System.Linq;

class SortedNumbers
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        nums = nums.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
        Console.WriteLine(String.Join(", ", nums));
    }
}