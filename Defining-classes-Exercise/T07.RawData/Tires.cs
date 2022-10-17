using System;

namespace DefiningClasses
{
	public class Tires
	{
        public double Pressure { get; set; }

        public int Age { get; set; }

        public Tires(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
    }
}

