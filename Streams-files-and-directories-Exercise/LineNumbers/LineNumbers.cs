namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"../../../text.txt";
            string outputFilePath = @"../../../output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            int lineCounter = 1;
            foreach (var line in lines)
            {
                int letters = line.Count(char.IsLetter);
                int punctuationMarks = line.Count(char.IsPunctuation);

                Console.WriteLine($"Line {lineCounter}: {line} ({letters})({punctuationMarks})");
            }
        }
    }
}
