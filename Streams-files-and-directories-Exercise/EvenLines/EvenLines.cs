namespace EvenLines
{
    using System;
    using System.IO;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"../../../text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int counter = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter % 2 == 0)
                    {
                        //replacing '-', ', ', '. ', '! ', '? ' with '@'
                        line = line.Replace('-', '@')
                            .Replace(',', '@')
                            .Replace('.', '@')
                            .Replace('!', '@')
                            .Replace('?', '@');

                        string[] processedLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string[] finalLine = new string[processedLine.Length];
                        for (int i = 0; i < processedLine.Length; i++)
                        {
                            finalLine[i] = processedLine[processedLine.Length - i - 1];
                        }
                        Console.WriteLine(String.Join(" ", finalLine));
                    }

                    counter++;
                }
            }

            return String.Empty;
        }
    }
}
