using System;
using System.Linq;
using System.Collections.Generic;

namespace GenericSwapMethodString
{
    class StartUp
    {
        public static void Main()
        {
            int stringsCount = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < stringsCount; i++)
            {
                int currInteger = int.Parse(Console.ReadLine());
                list.Add(currInteger);
            }

            int[] indeces = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstIndex = indeces[0];
            int secondIndex = indeces[1];
            Box<int> newBox = new Box<int>(list);

            newBox.Swapper(list, firstIndex, secondIndex);

            foreach (int currInteger in list)
            {
                Console.WriteLine($"{currInteger.GetType()}: {currInteger}");
            }
        }
    }
}