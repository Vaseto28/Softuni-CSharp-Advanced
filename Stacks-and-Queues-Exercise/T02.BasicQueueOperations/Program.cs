using System;
using System.Collections.Generic;
using System.Linq;

class BasicStackOperations
{
    static void Main()
    {
        int[] @params = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = @params[0];
        int s = @params[1];
        int x = @params[2];

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            queue.Enqueue(numbers[i]);
        }

        for (int i = 0; i < s; i++)
        {
            queue.Dequeue();
        }

        if (queue.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (queue.Contains(x))
        {
            Console.WriteLine("true");
        }
        else if (!queue.Contains(x))
        {
            Console.WriteLine(queue.Min());
        }
    }
}