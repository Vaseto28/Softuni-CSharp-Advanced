using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"../../../input.txt";
            string outputPath = @"../../../output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader sr = new StreamReader(inputFilePath);
            using (sr)
            {
                StreamWriter sw = new StreamWriter(outputFilePath);
                using (sw)
                {
                    int rowCounter = 1;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(rowCounter + ". " + line);
                        rowCounter++;
                    }
                }
            }
        }
    }
}