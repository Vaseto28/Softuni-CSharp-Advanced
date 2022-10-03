using System;
using System.Linq;

class PascalTraingle
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        long[][] pascalTraingle = new long[rows][];

        for (int row = 0; row < rows; row++)
        {
            pascalTraingle[row] = new long[row + 1];
            pascalTraingle[row][0] = 1;

            for (int col = 1; col < row; col++)
            {
                pascalTraingle[row][col] = pascalTraingle[row - 1][col - 1] + pascalTraingle[row - 1][col];
            }

            pascalTraingle[row][row] = 1;
        }

        PrintJaggedArray(rows, pascalTraingle);
    }

    private static void PrintJaggedArray(int rows, long[][] jaggedArray)
    {
        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(String.Join(" ", jaggedArray[row]));
        }
    }
}