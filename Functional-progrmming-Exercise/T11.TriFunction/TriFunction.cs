using System;
using System.Linq;
using System.Collections.Generic;

class TriFunction
{
    public static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split();

        foreach (var name in names)
        {
            int currSum = 0;
            foreach (var ch in name)
            {
                currSum += ch;
            }

            if (currSum >= sum)
            {
                Console.WriteLine(name);
                break;
            }
        }
    }
}