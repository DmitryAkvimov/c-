using System;

class Program
{
    static void TransposeMatrix(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int[,] transposed = new int[cols, rows];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = array[i, j];
            }
        }

        Console.WriteLine("Транспонированный массив:");
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(transposed[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] array =
        {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };
        TransposeMatrix(array);
    }
}
