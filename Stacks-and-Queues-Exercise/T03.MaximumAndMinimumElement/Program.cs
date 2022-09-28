using System;
using System.Linq;
using System.Collections.Generic;

class MaximumAndMinimumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();
            int numberOfCommand = int.Parse(command[0]);
            if (numberOfCommand == 1)
            {
                stack.Push(int.Parse(command[1]));
            }
            else if (numberOfCommand == 2)
            {
                if (stack.Count <= 0)
                {
                    continue;
                }
                stack.Pop();
            }
            else if (numberOfCommand == 3)
            {
                if (stack.Count <= 0)
                {
                    continue;
                }
                Console.WriteLine(stack.Max());
            }
            else if (numberOfCommand == 4)
            {
                if (stack.Count <= 0)
                {
                    continue;
                }
                Console.WriteLine(stack.Min());
            }
        }

        Console.WriteLine(String.Join(", ", stack));
    }
}