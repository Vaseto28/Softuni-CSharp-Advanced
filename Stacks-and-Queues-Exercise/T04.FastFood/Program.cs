using System;
using System.Linq;
using System.Collections.Generic;

class FastFood
{
    static void Main()
    {
        int availableFood = int.Parse(Console.ReadLine());

        Queue<int> orders = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
        Console.WriteLine(orders.Max());
        while (orders.Count > 0)
        {
            int currOrder = orders.Peek();
            if (availableFood >= currOrder)
            {
                availableFood -= currOrder;
                orders.Dequeue();
            }
            else
            {
                break;
            }
        }

        if (orders.Count <= 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
        }
    }
}