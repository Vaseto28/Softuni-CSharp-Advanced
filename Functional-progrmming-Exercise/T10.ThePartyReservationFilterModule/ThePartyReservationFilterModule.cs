using System;
using System.Linq;
using System.Collections.Generic;

class ThePartyReservationFilterModule
{
    public static void Main()
    {
        List<string> guests = new List<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

        List<string> filters = new List<string>();

        string command;
        while ((command = Console.ReadLine()) != "Print")
        {
            string[] info = command.Split(';', StringSplitOptions.RemoveEmptyEntries);
            string action = info[0];
            if (action == "Add filter")
            {
                string filterAndParam = info[1] + " " + info[2];
                filters.Add(filterAndParam);
            }
            else if (action == "Remove filter")
            {
                string filterAndParam = info[1] + " " + info[2];
                filters.Remove(filterAndParam);
            }
        }

        foreach (var filter in filters)
        {
            string[] filterInfo = filter.Split(' ');
            string action = filterInfo[0];

            if (action == "Starts")
            {
                guests = guests.Where(x => !x.StartsWith(filterInfo[2])).ToList();
            }
            else if (action == "Ends")
            {
                guests = guests.Where(x => !x.EndsWith(filterInfo[2])).ToList();
            }
            else if (action == "Length")
            {
                guests = guests.Where(x => x.Length != int.Parse(filterInfo[1])).ToList();
            }
            else if (action == "Contains")
            {
                guests = guests.Where(x => !x.Contains(filterInfo[1])).ToList();
            }
        }

        if (guests.Any())
        {
            Console.WriteLine(String.Join(" ", guests));
        }
    }
}