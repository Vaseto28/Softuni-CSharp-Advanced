using System;
using System.Linq;
using System.Collections.Generic;

class FashionButique
{
    static void Main()
    {
        Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        int capacity = int.Parse(Console.ReadLine());
        int sum = 0;
        int racksCounter = 1;

        while (clothes.Count > 0)
        {
            if (sum + clothes.Peek() < capacity)
            {
                sum += clothes.Pop();
            }
            else if (sum + clothes.Peek() == capacity)
            {
                clothes.Pop();
                sum = 0;
                if (clothes.Count>0)
                {
                    racksCounter++;
                }
            }
            else
            {
                sum = 0;
                sum += clothes.Pop();
                racksCounter++;
            }
        }

        Console.WriteLine(racksCounter);
    }
}