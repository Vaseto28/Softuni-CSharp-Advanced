using System;
using System.Linq;

class JaggedArrayModification
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[rows][];

        ReadJaggedArray(rows, jaggedArray);

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] information = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string action = information[0];
            if (action == "Add")
            {
                int row = int.Parse(information[1]);
                int col = int.Parse(information[2]);
                int value = int.Parse(information[3]);

                if (ValidatingCordinates(row, col, rows, jaggedArray))
                {
                    jaggedArray[row][col] += value;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            else if (action == "Subtract")
            {
                int row = int.Parse(information[1]);
                int col = int.Parse(information[2]);
                int value = int.Parse(information[3]);

                if (ValidatingCordinates(row, col, rows, jaggedArray))
                {
                    jaggedArray[row][col] -= value;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
        }

        PrintJaggedArray(rows, jaggedArray);
    }

    private static void PrintJaggedArray(int rows, int[][] jaggedArray)
    {
        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(String.Join(" ", jaggedArray[row]));
        }
    }

    private static bool ValidatingCordinates(int row, int col, int rows, int[][] jaggedArray)
    {
        if (row >= 0 && row < rows && col >= 0 && col < jaggedArray[row].Length)
        {
            return true;
        }
        return false;
    }

    private static void ReadJaggedArray(int rows, int[][] jaggedArray)
    {
        for (int row = 0; row < rows; row++)
        {
            int[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            jaggedArray[row] = elements;
        }
    }
}