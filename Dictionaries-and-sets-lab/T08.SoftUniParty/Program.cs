using System;
using System.Linq;
using System.Collections.Generic;

class SoftUniParty
{
    public static void Main()
    {
        HashSet<string> normalGuests = new HashSet<string>();
        HashSet<string> vipGuests = new HashSet<string>();

        string input;
        while ((input = Console.ReadLine()) != "PARTY")
        {
            string currNumber = input;
            if (char.IsDigit(currNumber[0]))
            {
                vipGuests.Add(currNumber);
            }
            else
            {
                normalGuests.Add(currNumber);
            }
        }

        string guest;
        while ((guest = Console.ReadLine()) != "END")
        {
            if (char.IsDigit(guest[0]))
            {
                vipGuests.Remove(guest);
            }
            else
            {
                normalGuests.Remove(guest);
            }
        }

        Console.WriteLine(vipGuests.Count + normalGuests.Count);
        if (vipGuests.Count > 0)
        {
            Console.WriteLine(String.Join(Environment.NewLine, vipGuests));
        }

        if (normalGuests.Count > 0)
        {
            Console.WriteLine(String.Join(Environment.NewLine, normalGuests));
        }
    }
}