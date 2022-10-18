using System;
using System.Collections.Generic;

namespace GenericSwapMethodString
{
	public class Box<T>
	{
        public List<T> List { get; set; }

        public Box(List<T> list)
        {
            this.List = list;
        }

        public void Swapper(List<T> list, int firstIndex, int secondIndex)
        {
            T firstElement = list[firstIndex];
            T secondElement = list[secondIndex];

            list[firstIndex] = secondElement;
            list[secondIndex] = firstElement;
        }
    }
}

