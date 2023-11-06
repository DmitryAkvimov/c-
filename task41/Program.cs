/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

using System;

int GetCountOfPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] GetUserArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            array[i] = userInput;
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите целое число.");
            i--;
        }
    }
    return array;
}

int[] userArray = GetUserArray(9);
int count = GetCountOfPositiveNumbers(userArray);
Console.WriteLine($"Количество чисел больше нуля: {count}");
