//1. Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго. 

//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

using System;

class Program
{
    static bool IsSquare(int number1, int number2)
    {
        // Проверяем, является ли первое число квадратом второго
        return number1 == number2 * number2;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        // Проверка и вывод результата
        if (IsSquare(num1, num2))
        {
            Console.WriteLine($"{num1} является квадратом {num2}.");
        }
        else
        {
            Console.WriteLine($"{num1} не является квадратом {num2}.");
        }
    }
}