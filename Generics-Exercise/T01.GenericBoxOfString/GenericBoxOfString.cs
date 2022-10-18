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
                string currStr = Console.ReadLine();
                Box<string> strBox = new Box<string>(currStr);
                Console.WriteLine(strBox);
            }
        }
    }
}