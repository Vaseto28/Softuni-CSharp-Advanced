using System;
using System.Collections.Generic;

namespace T08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int trafficlightCapacity = int.Parse(Console.ReadLine());
            int passedCars = 0;
            Queue<string> carsInTraffic = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "green")
                {
                    for (int i = 0; i < trafficlightCapacity; i++)
                    {
                        if (carsInTraffic.Count > 0)
                        {
                            Console.WriteLine($"{carsInTraffic.Dequeue()} passed!");
                            passedCars++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (command == "end")
                {
                    Console.WriteLine($"{passedCars} cars passed the crossroads.");
                    break;
                }
                else
                {
                    carsInTraffic.Enqueue(command);
                }
            }
        }
    }
}

