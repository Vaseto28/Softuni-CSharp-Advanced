using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniParty
{
    public static void Main()
    {
        HashSet<string> numbers = new HashSet<string>();
        HashSet<string> vipNumbers = new HashSet<string>();

        string firstCommands;
        int counter1 = 0;
        while ((firstCommands = Console.ReadLine()) != "PARTY")
        {
            string currNumber = firstCommands;
            numbers.Add(currNumber);
            counter1++;
        }

        string secondCommands;
        int counter2 = 0;
        while ((secondCommands = Console.ReadLine()) != "END")
        {
            string currNumber = secondCommands;
            numbers.Remove(currNumber);
            counter2++;
        }

        foreach (var number in numbers)
        {
            if (char.IsDigit(number[0]))
            {
                vipNumbers.Add(number);
                numbers.Remove(number);
            }
        }

        Console.WriteLine(counter1 - counter2);
        if (vipNumbers.Count > 0)
        {
            foreach (var vipNumber in vipNumbers)
            {
                Console.WriteLine(vipNumber);
            }
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}