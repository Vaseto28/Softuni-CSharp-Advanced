using System;
using System.Linq;

class JaggedArrayManipulator
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[rows][];

        ReadJaggedArray(rows, jaggedArray);

        for (int row = 0; row < rows - 1; row++)
        {
            if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
            {
                for (int i = 0; i < jaggedArray[row].Length; i++)
                {
                    jaggedArray[row][i] *= 2;
                }

                for (int i = 0; i < jaggedArray[row + 1].Length; i++)
                {
                    jaggedArray[row + 1][i] *= 2;
                }
            }
            else
            {
                for (int i = 0; i < jaggedArray[row].Length; i++)
                {
                    jaggedArray[row][i] /= 2;
                }

                for (int i = 0; i < jaggedArray[row + 1].Length; i++)
                {
                    jaggedArray[row + 1][i] /= 2;
                }
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] information = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string action = information[0];
            if (action == "Add")
            {
                if (ValidCordinates(information, rows, jaggedArray))
                {
                    int row = int.Parse(information[1]);
                    int col = int.Parse(information[2]);
                    int value = int.Parse(information[3]);

                    jaggedArray[row][col] += value;
                }
            }
            else if (action == "Subtract")
            {
                if (ValidCordinates(information, rows, jaggedArray))
                {
                    int row = int.Parse(information[1]);
                    int col = int.Parse(information[2]);
                    int value = int.Parse(information[3]);

                    jaggedArray[row][col] -= value;
                }
            }
        }

        PrintJaggedArray(rows, jaggedArray);
    }

    private static bool ValidCordinates(string[] information, int rows, int[][] jaggedArray)
    {
        int row = int.Parse(information[1]);
        int col = int.Parse(information[2]);

        if (row >= 0 && row < rows
            && col >= 0 && col < jaggedArray[row].Length)
        {
            return true;
        }

        return false;
    }

    private static void PrintJaggedArray(int rows, int[][] jaggedArray)
    {
        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(String.Join(" ", jaggedArray[row]));
        }
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