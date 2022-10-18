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
            List<string> list = new List<string>();
            for (int i = 0; i < stringsCount; i++)
            {
                string currStr = Console.ReadLine();
                list.Add(currStr);
            }

            int[] indeces = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstIndex = indeces[0];
            int secondIndex = indeces[1];
            Box<string> newBox = new Box<string>(list);

            newBox.Swapper(list, firstIndex, secondIndex);

            foreach (string str in list)
            {
                Console.WriteLine($"{typeof(string)}: {str}");
            }
        }
    }
}