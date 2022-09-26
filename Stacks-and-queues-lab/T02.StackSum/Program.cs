using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(intArray);

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                string[] arguments = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = arguments[0];
                if (action == "add")
                {
                    int firstNum = int.Parse(arguments[1]);
                    int secondNum = int.Parse(arguments[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (action == "remove")
                {
                    int num = int.Parse(arguments[1]);
                    if (stack.Count>=num)
                    {

                        for (int i = 0; i < num; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else
                {
                    int sum = stack.Sum();
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
            }
        }
    }
}

