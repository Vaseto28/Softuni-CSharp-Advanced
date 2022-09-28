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
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            stack.Push(numbers[i]);
        }

        for (int i = 0; i < s; i++)
        {
            stack.Pop();
        }

        if (stack.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (stack.Contains(x))
        {
            Console.WriteLine("true");
        }
        else if (!stack.Contains(x))
        {
            Console.WriteLine(stack.Min());
        }
    }
}