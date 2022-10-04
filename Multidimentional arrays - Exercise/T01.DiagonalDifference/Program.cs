using System;
using System.Linq;

class DiagonalDifference
{
    static void Main()
    {
        int dimention = int.Parse(Console.ReadLine());
        int[,] matrix = new int[dimention, dimention];

        ReadMatrix(dimention, matrix);

        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        for (int row = 0; row < dimention; row++)
        {
            for (int col = 0; col < dimention; col++)
            {
                if (row == col)
                {
                    primaryDiagonalSum += matrix[row, col];
                }

                if (row + col == dimention - 1)
                {
                    secondaryDiagonalSum += matrix[row, col];
                }
            }
        }

        Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
    }

    private static void ReadMatrix(int dimention, int[,] matrix)
    {
        for (int row = 0; row < dimention; row++)
        {
            int[] matrixElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < matrixElements.Length; col++)
            {
                matrix[row, col] = matrixElements[col];
            }
        }
    }
}