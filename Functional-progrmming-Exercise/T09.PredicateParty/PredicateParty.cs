using System;
using System.Linq;
using System.Collections.Generic;

class PredicateParty
{
    public static void Main()
    {
        List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();



        string command;
        while ((command = Console.ReadLine()) != "Party!")
        {
            string[] info = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string action = info[0];
            if (action == "Remove")
            {
                string property = info[1];
                if (property == "StartsWith")
                {
                    string str = info[2];
                    Predicate<string> checker = x => !x.StartsWith(str);
                    names = names.Where(x => checker(x)).ToList();
                }
                else if (property == "EndsWith")
                {
                    string str = info[2];
                    Predicate<string> checker = x => !x.EndsWith(str);
                    names = names.Where(x => checker(x)).ToList();
                }
                else if (property == "Length")
                {
                    int length = int.Parse(info[2]);
                    Predicate<string> checker = x => x.Length != length;
                    names = names.Where(x => checker(x)).ToList();
                }
            }
            else if (action == "Double")
            {
                string property = info[1];
                if (property == "StartsWith")
                {
                    string str = info[2];
                    Predicate<string> checker = x => x.StartsWith(str);
                    names.AddRange(names.Where(x => checker(x)).ToList());
                }
                else if (property == "EndsWith")
                {
                    string str = info[2];
                    Predicate<string> checker = x => x.EndsWith(str);
                    names.AddRange(names.Where(x => checker(x)).ToList());
                }
                else if (property == "Length")
                {
                    int length = int.Parse(info[2]);
                    Predicate<string> checker = x => x.Length == length;
                    names.AddRange(names.Where(x => checker(x)).ToList());
                }
            }
        }

        if (names.Count > 0)
            Console.WriteLine($"{String.Join(", ", names)} are going to the party!");
        else
            Console.WriteLine("Nobody is going to the party!");
    }
}