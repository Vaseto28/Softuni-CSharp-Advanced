using System;
using System.Linq;
using System.Collections.Generic;

class AppliedArithmetics
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        Func<int, int> add = x => x + 1;
        Func<int, int> multiply = x => x * 2;
        Func<int, int> subtract = x => x - 1;
        Action<List<int>> print = x => Console.WriteLine(String.Join(" ", x));

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            if (command == "add")
            {
                numbers = numbers.Select(add).ToList();
            }
            else if (command == "multiply")
            {
                numbers = numbers.Select(multiply).ToList();
            }
            else if (command == "subtract")
            {
                numbers = numbers.Select(subtract).ToList();
            }
            else if (command == "print")
            {
                print(numbers);
            }
        }
    }
}