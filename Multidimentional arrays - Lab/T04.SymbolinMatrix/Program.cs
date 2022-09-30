using System;
using System.Linq;

class SymbolInMatrix
{
    static void Main()
    {
        int dimention = int.Parse(Console.ReadLine());
        char[,] matrix = new char[dimention, dimention];

        ReadMatrix(dimention, matrix);

        char symbol = char.Parse(Console.ReadLine());

        for (int row = 0; row < dimention; row++)
        {
            for (int col = 0; col < dimention; col++)
            {
                int currCh = matrix[row, col];
                if (currCh == symbol)
                {
                    Console.WriteLine($"({row}, {col})");
                    return; ;
                }
            }
        }

        Console.WriteLine($"{symbol} does not occur in the matrix");
    }

    private static void ReadMatrix(int dimention, char[,] matrix)
    {
        for (int row = 0; row < dimention; row++)
        {
            string matrixElements = Console.ReadLine();
            for (int col = 0; col < matrixElements.Length; col++)
            {
                matrix[row, col] = matrixElements[col];
            }
        }
    }
}