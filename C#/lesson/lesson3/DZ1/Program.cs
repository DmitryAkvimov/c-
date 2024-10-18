using System;

class Program
{
    static bool IsNumberPresent(int[] numbers, int numberToFind)
    {
        foreach (int number in numbers)
        {
            if (number == numberToFind)
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 19, 3 }; // Пример массива
        int numberToFind = 8; // Пример числа для поиска
        if (IsNumberPresent(numbers, numberToFind))
        {
            Console.WriteLine("Присутствует");
        }
        else
        {
            Console.WriteLine("Не присутствует");
        }
    }
}
