using System;

class ArrayExample
{
    static void Main()
    {
        // 1. Single-Dimensional Array
        int[] singleDimensionalArray = new int[5];

        // Initializing values in the array
        for (int i = 0; i < 5; i++)
        {
            singleDimensionalArray[i] = i * 10;
        }

        // Accessing and displaying values in the array
        Console.WriteLine("Single-Dimensional Array:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Index {i}: {singleDimensionalArray[i]}");
        }

        // 2. Multi-Dimensional Array (2D Array)
        int[,] twoDimensionalArray = new int[3, 3];

        // Initializing values in the 2D array
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                twoDimensionalArray[row, col] = row + col;
            }
        }

        // Accessing and displaying values in the 2D array
        Console.WriteLine("\nTwo-Dimensional Array (2D Array):");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"{twoDimensionalArray[row, col]} ");
            }
            Console.WriteLine();
        }

        // 3. Jagged Array
        int[][] jaggedArray = new int[3][];

        // Initializing values in the jagged array
        for (int i = 0; i < 3; i++)
        {
            jaggedArray[i] = new int[i + 1]; // Different size for each row
            for (int j = 0; j <= i; j++)
            {
                jaggedArray[i][j] = i + j;
            }
        }

        // Accessing and displaying values in the jagged array
        Console.WriteLine("\nJagged Array:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"{jaggedArray[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}
