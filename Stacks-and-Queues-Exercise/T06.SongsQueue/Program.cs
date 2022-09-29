using System;
using System.Linq;
using System.Collections.Generic;

class SongsQueue
{
    static void Main(string[] args)
    {
        Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

        while (songsQueue.Count > 0)
        {
            string command = Console.ReadLine();
            if (command == "Play")
            {
                songsQueue.Dequeue();
            }
            else if (command == "Show")
            {
                Console.WriteLine(String.Join(", ", songsQueue));
            }
            else
            {
                string song = command.Substring(4);
                if (songsQueue.Contains(song))
                {
                    Console.WriteLine($"{song} is already contained!");
                }
                else
                {
                    songsQueue.Enqueue(song);
                }
            }
        }

        Console.WriteLine("No more songs!");
    }
}