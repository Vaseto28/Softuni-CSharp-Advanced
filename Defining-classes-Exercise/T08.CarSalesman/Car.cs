using System;

namespace DefiningClasses
{
	public class Car
	{
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Colour { get; set; }

        //ctors
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
        }

        public Car(string model, Engine engine, int weight, string colour) : this(model, engine, weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Colour = colour;
        }
    }
}

