using System;
using System.Linq;
using System.Collections.Generic;

class BalancedParenthesis
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Stack<char> parenthesis = new Stack<char>();

        foreach (char ch in input)
        {
            if (parenthesis.Count != 0)
            {
                char secondCh = parenthesis.Peek();
                if (secondCh == '(' && ch == ')')
                {
                    parenthesis.Pop();
                    continue;
                }

                if (secondCh == '[' && ch == ']')
                {
                    parenthesis.Pop();
                    continue;
                }

                if (secondCh == '{' && ch == '}')
                {
                    parenthesis.Pop();
                    continue;
                }
            }

            parenthesis.Push(ch);
        }

        if (parenthesis.Count <= 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
