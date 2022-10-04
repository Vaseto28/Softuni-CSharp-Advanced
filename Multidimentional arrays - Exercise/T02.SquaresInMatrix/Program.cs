using System;
using System.Linq;

class SquaresInMatrix
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];

        char[,] matrix = new char[rows, cols];

        ReadMatrix(rows, matrix);

        int counter = 0;
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                int currElement = matrix[row, col];
                if (currElement == matrix[row, col + 1]
                    && currElement == matrix[row + 1, col]
                    && currElement == matrix[row + 1, col + 1])
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }

    private static void ReadMatrix(int rows, char[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            char[] matrixElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            for (int col = 0; col < matrixElements.Length; col++)
            {
                matrix[row, col] = matrixElements[col];
            }
        }
    }
}