using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];

        int[,] matrix = new int[rows, cols];

        ReadMatrix(rows, matrix);

        int biggestSum = int.MinValue;
        int[,] finalMatrix = new int[3, 3];
        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (currSum > biggestSum)
                {
                    biggestSum = currSum;
                    finalMatrix[0, 0] = matrix[row, col];
                    finalMatrix[0, 1] = matrix[row, col + 1];
                    finalMatrix[0, 2] = matrix[row, col + 2];

                    finalMatrix[1, 0] = matrix[row + 1, col];
                    finalMatrix[1, 1] = matrix[row + 1, col + 1];
                    finalMatrix[1, 2] = matrix[row + 1, col + 2];

                    finalMatrix[2, 0] = matrix[row + 2, col];
                    finalMatrix[2, 1] = matrix[row + 2, col + 1];
                    finalMatrix[2, 2] = matrix[row + 2, col + 2];
                }
            }
        }

        Console.WriteLine($"Sum = {biggestSum}");
        PrintMatrix(finalMatrix);
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

    private static void PrintMatrix(int[,] finalMatrix)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(finalMatrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}