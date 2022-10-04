using System;
using System.Linq;

class SnakeMoves
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];

        char[,] matrix = new char[rows, cols];

        char[] snake = Console.ReadLine().ToCharArray();

        int index = 0;
        for (int row = 0; row < rows; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = snake[index];
                    index++;

                    if (index == snake.Length)
                    {
                        index = 0;
                    }
                }
            }
            else
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake[index];
                    index++;

                    if (index == snake.Length)
                    {
                        index = 0;
                    }
                }
            }
        }

        PrintMatrix(rows, cols, matrix);
    }

    private static void PrintMatrix(int rows, int cols, char[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}