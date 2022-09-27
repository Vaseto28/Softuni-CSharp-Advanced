using System;
using System.Collections.Generic;

namespace T06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Paid")
                {
                    Console.WriteLine(String.Join(Environment.NewLine, queue));
                    queue.Clear();
                }
                else if (command == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}

