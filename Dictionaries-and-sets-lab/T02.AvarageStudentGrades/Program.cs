using System;
using System.Linq;
using System.Collections.Generic;

class AvarageStudentGrades
{
    public static void Main()
    {
        Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

        int studentsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentsCount; i++)
        {
            string[] info = Console.ReadLine().Split();
            string name = info[0];
            decimal grade = decimal.Parse(info[1]);

            if (!students.ContainsKey(name))
            {
                students.Add(name, new List<decimal>());
            }
            students[name].Add(grade);
        }

        foreach (var kvp in students)
        {
            decimal avg = kvp.Value.Average();
            Console.WriteLine($"{kvp.Key} -> {String.Join(" ", kvp.Value.Select(x => x.ToString("f2")))} (avg: {avg:f2})");
        }
    }
}