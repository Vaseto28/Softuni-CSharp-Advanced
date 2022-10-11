namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"/report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, List<FileInfo>> filesInfo = new Dictionary<string, List<FileInfo>>();
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extention = fileInfo.Extension;
                if (!filesInfo.ContainsKey(extention))
                {
                    filesInfo.Add(extention, new List<FileInfo>());
                }
                filesInfo[extention].Add(fileInfo);
            }

            foreach (var file in filesInfo.OrderByDescending(file => file.Value.Count).ThenBy(file => file.Key))
            {
                string extention = file.Key;
                Console.WriteLine(extention);

                foreach (var filesProperties in filesInfo[extention].OrderBy(file => file.Length))
                {
                    Console.WriteLine($"--{filesProperties.Name} - {(filesProperties.Length / 1024):f3}kb");
                }
            }

            return String.Empty;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string pathReport = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(pathReport, textContent);
        }
    }
}
