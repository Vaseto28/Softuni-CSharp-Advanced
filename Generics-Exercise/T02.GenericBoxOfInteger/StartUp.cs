using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main()
        {
            int stringsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < stringsCount; i++)
            {
                int currInt = int.Parse(Console.ReadLine());
                Box<int> boxOfIntegers = new Box<int>(currInt);
                Console.WriteLine(boxOfIntegers);
            }
        }
    }
}