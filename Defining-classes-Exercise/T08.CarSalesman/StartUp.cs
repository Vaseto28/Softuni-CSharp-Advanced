using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Engine> engines = new List<Engine>();
            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                int displacement = 0;
                string efficiency = null;
                if (engineInfo.Length >= 3)
                {
                    displacement = int.Parse(engineInfo[2]);
                }

                if (engineInfo.Length == 4)
                {
                    efficiency = engineInfo[3];
                }

                if (engineInfo.Length == 2)
                {
                    Engine newEngine = new Engine(model, power);
                    engines.Add(newEngine);
                }
                else if (engineInfo.Length == 3)
                {
                    Engine newEngine = new Engine(model, power, displacement);
                    engines.Add(newEngine);
                }
                else
                {
                    Engine newEngine = new Engine(model, power, displacement, efficiency);
                    engines.Add(newEngine);
                }
            }

            List<Car> cars = new List<Car>();
            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engineModel = carInfo[1];
                int weight = 0;
                string colour = null;

                if (carInfo.Length >= 3)
                {
                    weight = int.Parse(carInfo[2]);
                }

                if (carInfo.Length == 4)
                {
                    colour = carInfo[3];
                }

                //Setting the engine
                List<Engine> currEngine = engines.Where(x => x.Model == engineModel).ToList();
                Engine thisEngine = currEngine[0];

                if (carInfo.Length == 2)
                {
                    Car newCar = new Car(model, thisEngine);
                    cars.Add(newCar);
                }
                else if (carInfo.Length == 3)
                {
                    Car newCar = new Car(model, thisEngine, weight);
                    cars.Add(newCar);
                }
                else
                {
                    Car newCar = new Car(model, thisEngine, weight, colour);
                    cars.Add(newCar);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement != 0)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine("    Displacement: n/a");
                }

                if (car.Engine.Efficiency != null)
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine("     Efficiency: n/a");
                }

                if (car.Weight != 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine("  Weight: n/a");
                }

                if (car.Colour != null)
                {
                    Console.WriteLine($"  Color: {car.Colour}");
                }
                else
                {
                    Console.WriteLine("Color: n/a");
                }
            }
        }
    }
}

