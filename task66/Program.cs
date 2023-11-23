/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;

class NaturalNumbersSum
{
    void Run()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        if (m > 0 && n >= m)
        {
            int sum = GetSumOfNaturalNumbers(m, n);
            Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");
        }
        else
        {
            Console.WriteLine("Значение M должно быть положительным и меньше или равно N.");
        }
    }

    int GetSumOfNaturalNumbers(int m, int n)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        NaturalNumbersSum program = new NaturalNumbersSum();
        program.Run();
    }
}
