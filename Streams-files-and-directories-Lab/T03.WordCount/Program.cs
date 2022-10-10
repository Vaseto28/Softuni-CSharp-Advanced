using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"../../../words.txt";
            string textPath = @"../../../text.txt";
            string outputPath = @"../../../output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> occurances = new Dictionary<string, int>();
            StreamReader sr = new StreamReader(wordsFilePath);
            using (sr)
            {
                string[] wordsToSearch = sr.ReadLine().Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                StreamReader sr2 = new StreamReader(textFilePath);
                using (sr2)
                {
                    //char[] separators = new char[] { ',', '.', ' ', '?', '!', '"', '(', ')', '-' };
                    string[] words = sr2.ReadLine().Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                    StreamWriter sw = new StreamWriter(outputFilePath);
                    using (sw)
                    {
                        foreach (var word in wordsToSearch)
                        {
                            if (!occurances.ContainsKey(word))
                            {
                                occurances.Add(word, 0);
                            }
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (word == words[i].ToLower())
                                {
                                    occurances[word]++;
                                }
                            }
                        }

                        foreach (var kvp in occurances)
                        {
                            sw.WriteLine($"{kvp.Key} - {kvp.Value}");
                        }
                    }
                }
            }
        }
    }
}