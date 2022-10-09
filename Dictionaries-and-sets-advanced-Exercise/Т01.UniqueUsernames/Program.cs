using System;
using System.Linq;
using System.Collections.Generic;

class UniqueUsernames
{
    public static void Main()
    {
        HashSet<string> usernames = new HashSet<string>();
        int usernamesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < usernamesCount; i++)
        {
            string currUsername = Console.ReadLine();
            usernames.Add(currUsername);
        }

        Console.WriteLine(String.Join(Environment.NewLine, usernames));
    }
}