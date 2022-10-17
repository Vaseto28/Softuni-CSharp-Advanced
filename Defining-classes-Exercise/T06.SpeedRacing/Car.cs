using System;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }

        public decimal Fuel { get; set; }

        public decimal FuelConsumptionPerKilometer { get; set; }

        public decimal TravelledDistance { get; set; }

        public Car(string model, decimal fuel, decimal consumption, decimal travelledDistance)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelConsumptionPerKilometer = consumption;
            this.TravelledDistance = travelledDistance;
        }

        public bool IsItAbleToDriveTheDistance(decimal distance)
        {
            if (distance * this.FuelConsumptionPerKilometer <= this.Fuel)
            {
                this.Fuel -= distance * this.FuelConsumptionPerKilometer;
                this.TravelledDistance += distance;
                return true;
            }

            return false;
        }
    }
}

