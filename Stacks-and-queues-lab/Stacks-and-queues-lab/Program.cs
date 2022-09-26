using System;
using System.Collections.Generic;

namespace Stacks_and_queues_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var ch in text)
            {
                stack.Push(ch);
            }

            Console.WriteLine(String.Join("", stack));
        }
    }
}

