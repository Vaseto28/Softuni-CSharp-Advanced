using System;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public T Str { get; set; }

        public Box(T str)
        {
            this.Str = str;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Str}";
        }
    }
}

