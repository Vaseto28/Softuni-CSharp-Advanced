using System;
using System.Linq;
using System.Collections.Generic;

namespace T03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());

            while (stack.Count>1)
            {
                int firstNum = int.Parse(stack.Pop());
                char @oparator = char.Parse(stack.Pop());
                int secondNum = int.Parse(stack.Pop());
                string result = String.Empty;

                if (oparator == '+')
                {
                    result = (firstNum + secondNum).ToString();
                }
                else
                {
                    result = (firstNum - secondNum).ToString();
                }

                stack.Push(result);
            }

            Console.WriteLine(String.Join("", stack));
        }
    }
}

