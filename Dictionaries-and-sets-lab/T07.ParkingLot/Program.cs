using System;
using System.Linq;
using System.Collections.Generic;

class ParkingLot
{
    public static void Main()
    {
        HashSet<string> plates = new HashSet<string>();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] info = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string action = info[0];
            string plate = info[1];

            if (action == "IN")
            {
                plates.Add(plate);
            }
            else if (action == "OUT")
            {
                plates.Remove(plate);
            }
        }

        if (plates.Count > 0)
            Console.WriteLine(String.Join(Environment.NewLine, plates));
        else
            Console.WriteLine("Parking Lot is Empty");
    }
}