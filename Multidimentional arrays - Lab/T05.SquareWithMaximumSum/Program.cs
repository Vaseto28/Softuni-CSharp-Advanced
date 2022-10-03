using System;
using System.Linq;

class SquareWithMaximumSum
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];

        int[,] matrix = new int[rows, cols];
        ReadMatrix(rows, matrix);

        int[,] biggestMatrix = new int[2, 2];
        int sum = int.MinValue;
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currSum > sum)
                {
                    sum = currSum;
                    biggestMatrix[0, 0] = matrix[row, col];
                    biggestMatrix[0, 1] = matrix[row, col + 1];
                    biggestMatrix[1, 0] = matrix[row + 1, col];
                    biggestMatrix[1, 1] = matrix[row + 1, col + 1];
                }
            }
        }

        PrintMatrix(biggestMatrix);
        Console.WriteLine(sum);
    }

    private static void ReadMatrix(int rows, int[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            int[] matrixElements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < matrixElements.Length; col++)
            {
                matrix[row, col] = matrixElements[col];
            }
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}