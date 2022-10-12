using System;
using System.Linq;

class CountUppercaseWords
{
    public static void Main()
    {
        Func<string, bool> checker = word => word.Length > 0 && char.IsUpper(word[0]);

        string[] words = Console.ReadLine().Split(' ').Where(w => checker(w)).ToArray();
        Console.WriteLine(String.Join(Environment.NewLine, words));
    }
}