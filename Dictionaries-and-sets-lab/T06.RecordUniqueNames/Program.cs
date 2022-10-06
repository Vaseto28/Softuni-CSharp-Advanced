using System;
using System.Linq;
using System.Collections.Generic;

class RecordUniqueNames
{
    public static void Main()
    {
        HashSet<string> names = new HashSet<string>();
        int namesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < namesCount; i++)
        {
            string currName = Console.ReadLine();
            names.Add(currName);
        }

        Console.WriteLine(String.Join(Environment.NewLine, names));
    }
}