using System;
using System.Linq;

class SumMatrixColumns
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];

        int[,] matrix = new int[rows, cols];

        ReadMatrix(rows, matrix);

        for (int col = 0; col < cols; col++)
        {
            int currSum = 0;
            for (int row = 0; row < rows; row++)
            {
                int currElement = matrix[row, col];
                currSum += currElement;
            }
            Console.WriteLine(currSum);
        }
    }

    private static void ReadMatrix(int rows, int[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            int[] matrixElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < matrixElements.Length; col++)
            {
                matrix[row, col] = matrixElements[col];
            }
        }
    }
}