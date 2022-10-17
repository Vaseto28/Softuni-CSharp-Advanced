using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                string[] components = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                //FirstCarProperty
                string model = components[0];

                //EngineProperties
                int speed = int.Parse(components[1]);
                int power = int.Parse(components[2]);
                Engine engine = new Engine(speed, power);

                //CargoProperties
                int cargoWeight = int.Parse(components[3]);
                string cargoType = components[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                //TireArrayProperties
                double firstPressure = double.Parse(components[5]);
                int firstAge = int.Parse(components[6]);
                Tires firstTire = new Tires(firstPressure, firstAge);

                double secondPressure = double.Parse(components[7]);
                int secondAge = int.Parse(components[8]);
                Tires secondTire = new Tires(secondPressure, secondAge);

                double thirdPressure = double.Parse(components[9]);
                int thirdAge = int.Parse(components[10]);
                Tires thirdTire = new Tires(thirdPressure, thirdAge);

                double fourthPressure = double.Parse(components[11]);
                int fourthAge = int.Parse(components[12]);
                Tires fourthTire = new Tires(fourthPressure, fourthAge);


                Tires[] tires = new Tires[4] { firstTire, secondTire, thirdTire, fourthTire };

                Car newCar = new Car(model, engine, cargo, tires);
                cars.Add(newCar);
            }

            string lastCommand = Console.ReadLine();
            cars = cars.Where(x => x.Cargo.Type == lastCommand).ToList();
            if (lastCommand == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Tires[0].Pressure < 1 ||
                        car.Tires[1].Pressure < 1 ||
                        car.Tires[2].Pressure < 1 ||
                        car.Tires[3].Pressure < 1)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (var car in cars)
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}

