using System;
using System.Linq;

class SumMatrixElement
{
    static void Main()
    {
        int[] matrixSize = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = matrixSize[0];
        int cols = matrixSize[1];
        int[,] matrix = new int[rows, cols];

        ReadMatrix(rows, matrix);

        int sum = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                sum += matrix[row, col];
            }
        }

        Console.WriteLine(rows);
        Console.WriteLine(cols);
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
}