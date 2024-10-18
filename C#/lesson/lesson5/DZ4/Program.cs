using System;

class Program
{
    static void ReplaceNegativeNumbers(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < 0)
                {
                    array[i, j] = -array[i, j];  // Превращаем отрицательное число в положительное
                }
            }
        }

        Console.WriteLine("Массив после замены отрицательных чисел:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] array =
        {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, -8, 9 }
        };
        ReplaceNegativeNumbers(array);
    }
}
