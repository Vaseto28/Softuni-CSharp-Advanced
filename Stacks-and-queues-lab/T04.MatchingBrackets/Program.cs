using System;
using System.Collections.Generic;

namespace T04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Stack<int> stack = new Stack<int>(); 
            for (int i = 0; i < inputLine.Length; i++)
            {
                char currChar = inputLine[i];
                if (currChar == '(')
                {
                    stack.Push(i);
                }
                else if (currChar == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string currExpression = inputLine.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(currExpression);
                }
            }
        }
    }
}

