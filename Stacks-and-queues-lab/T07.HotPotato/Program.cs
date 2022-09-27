using System;
using System.Collections.Generic;

namespace T07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> children = new Queue<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
            int n = int.Parse(Console.ReadLine());

            while (children.Count>1)
            {
                for (int i = 1; i < n; i++)
                { 
                    children.Enqueue(children.Dequeue());
                }
                Console.WriteLine($"Removed {children.Dequeue()}");
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}

