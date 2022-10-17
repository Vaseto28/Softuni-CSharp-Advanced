using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = info[0];
                decimal fuel = decimal.Parse(info[1]);
                decimal fuelConsumption = decimal.Parse(info[2]);
                decimal travelledDistance = 0;

                Car newCar = new Car(model, fuel, fuelConsumption, travelledDistance);
                cars.Add(newCar);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = info[1];
                decimal distance = decimal.Parse(info[2]);

                Car car = cars.Find(x => x.Model == model);
                if (!car.IsItAbleToDriveTheDistance(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.TravelledDistance}");
            }
        }
    }
}

