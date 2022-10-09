using System;
using System.Linq;
using System.Collections.Generic;

class SetsOfElements
{
    public static void Main()
    {
        int[] dimentionsForSets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

        for (int i = 0; i < dimentionsForSets[0]; i++)
        {
            int element = int.Parse(Console.ReadLine());
            if (!firstList.Contains(element))
            {
                firstList.Add(element);
            }
        }

        for (int i = 0; i < dimentionsForSets[1]; i++)
        {
            int element = int.Parse(Console.ReadLine());
            if (!secondList.Contains(element))
            {
                secondList.Add(element);
            }
        }

        List<int> occurances = new List<int>();
        for (int i = 0; i < firstList.Count; i++)
        {
            int currElement = firstList[i];
            if (secondList.Contains(currElement))
            {
                occurances.Add(currElement);
            }
        }

        Console.WriteLine(String.Join(" ", occurances));
    }
}