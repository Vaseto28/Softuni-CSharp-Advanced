using System;

namespace DefiningClasses
{
	public class Car
	{
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tires[] Tires { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
    }
}

