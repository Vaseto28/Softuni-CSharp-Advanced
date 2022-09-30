using System;
using System.Linq;

class PrimaryDiagonal
{
    static void Main()
    {
        int dimention = int.Parse(Console.ReadLine());
        int[,] matrix = new int[dimention, dimention];

        ReadMatrix(dimention, matrix);

        int sum = 0;
        for (int row = 0; row < dimention; row++)
        {
            for (int col = 0; col < dimention; col++)
            {
                if (row == col)
                {
                    sum += matrix[row, col];
                }
            }
        }

        Console.WriteLine(sum);
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