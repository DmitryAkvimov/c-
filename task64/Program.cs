/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


using System;

class NaturalNumbersProgram
{
    static void Main()
    {
        NaturalNumbersProgram program = new NaturalNumbersProgram();
        program.Run();
    }

    void Run()
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            Console.WriteLine("Результат: " + GetNaturalNumbers(n));
        }
        else
        {
            Console.WriteLine("N должно быть положительным числом.");
        }
    }

    string GetNaturalNumbers(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        else
        {
            return n + ", " + GetNaturalNumbers(n - 1);
        }
    }
}
