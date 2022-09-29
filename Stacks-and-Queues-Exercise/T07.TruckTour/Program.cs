using System;
using System.Linq;
using System.Collections.Generic;

class TruckTour
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var petrol = new Queue<int>();
        var distance = new Queue<int>();
        int[] input;
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            petrol.Enqueue(input[0]);
            distance.Enqueue(input[1]);
        }

        int currentFuel;
        for (int i = 0; i < n; i++)
        {
            currentFuel = petrol.Peek();
            for (int x = 0; x < n; x++)
            {
                if (distance.Peek() <= currentFuel)
                {
                    currentFuel -= distance.Peek();
                    if (x == n - 1)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
                else
                {
                    for (int y = x; y < n; y++)
                    {
                        petrol.Enqueue(petrol.Dequeue());
                        distance.Enqueue(distance.Dequeue());
                    }
                    break;
                }
                petrol.Enqueue(petrol.Dequeue());
                distance.Enqueue(distance.Dequeue());
                currentFuel += petrol.Peek();
            }
            petrol.Enqueue(petrol.Dequeue());
            distance.Enqueue(distance.Dequeue());
        }
    }
}
