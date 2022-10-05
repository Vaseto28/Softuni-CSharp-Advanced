using System;
using System.Linq;
using System.Collections.Generic;

class KnightGame
{
    static void Main()
    {
        int dimention = int.Parse(Console.ReadLine());
        char[,] matrix = new char[dimention, dimention];

        ReadMatrix(dimention, matrix);

        if (dimention == 2 || dimention == 1)
        {
            Console.WriteLine(0);
            return;
        }

        for (int row = 0; row < dimention; row++)
        {
            for (int col = 0; col < dimention; col++)
            {
                char currElement = matrix[row, col];
            }
        }
    }

    private static void ReadMatrix(int dimention, char[,] matrix)
    {
        for (int row = 0; row < dimention; row++)
        {
            string matrixElements = Console.ReadLine();
            for (int col = 0; col < dimention; col++)
            {
                matrix[row, col] = matrixElements[col];
            }
        }
    }
}