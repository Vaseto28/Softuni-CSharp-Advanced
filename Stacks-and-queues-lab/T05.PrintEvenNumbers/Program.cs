using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            foreach (var num in numbers)
            {
                if (num%2==0)
                {
                    queue.Enqueue(num);
                }
            }

            Console.WriteLine(String.Join(", ", queue));
        }
    }
}

