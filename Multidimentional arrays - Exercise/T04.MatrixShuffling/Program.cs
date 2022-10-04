using System;
using System.Linq;

class MatrixShuffling
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];

        string[,] matrix = new string[rows, cols];

        ReadMatrix(rows, matrix);

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            if (ValidatedCommand(rows, cols, command, matrix))
            {
                string[] information = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int row1 = int.Parse(information[1]);
                int col1 = int.Parse(information[2]);
                int row2 = int.Parse(information[3]);
                int col2 = int.Parse(information[4]);

                string firstElement = matrix[row1, col1];
                string secondElement = matrix[row2, col2];

                matrix[row1, col1] = secondElement;
                matrix[row2, col2] = firstElement;

                PrintMatrix(rows, cols, matrix);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }


    }

    private static void PrintMatrix(int rows, int cols, string[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    private static bool ValidatedCommand(int rows, int cols, string command, string[,] matrix)
    {
        string[] information = command.Split();
        if (command.StartsWith("swap") && information.Length == 5)
        {
            int row1 = int.Parse(information[1]);
            int col1 = int.Parse(information[2]);
            int row2 = int.Parse(information[3]);
            int col2 = int.Parse(information[4]);

            if (row1 >= 0 && row1 < rows
                && col1 >= 0 && col1 < cols
                && row2 >= 0 && row2 < rows
                && col2 >= 0 && col2 < cols)
            {
                return true;
            }

            //return false;
        }

        return false;
    }

    private static void ReadMatrix(int rows, string[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            string[] matrixElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < matrixElements.Length; col++)
            {
                matrix[row, col] = matrixElements[col];
            }
        }
    }
}