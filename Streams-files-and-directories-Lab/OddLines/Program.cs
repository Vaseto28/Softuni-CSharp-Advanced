using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"../../../input.txt";
            string outputFilePath = @"../../../output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader sr = new StreamReader(inputFilePath);
            using (sr)
            {
                StreamWriter sw = new StreamWriter(outputFilePath);
                using (sw)
                {
                    int counter = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (counter % 2 == 1)
                        {
                            sw.WriteLine(line);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}