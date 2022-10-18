using System;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public T Int { get; set; }

        public Box(T @int)
        {
            this.Int = @int;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Int}";
        }
    }
}

