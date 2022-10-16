using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Mercedes";
            car.Model = "W140";
            car.Year = 1996;

            Console.WriteLine($"Make: {car.Make}{Environment.NewLine}Model: {car.Model}{Environment.NewLine}Year: {car.Year}");
        }
    }
}

