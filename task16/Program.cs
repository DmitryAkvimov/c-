﻿/*
16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
    
// Проверяем, является ли первое число квадратом второго и наоборот и вывод результата    
if (number1 == number2 * number2 || number2 == number1 * number1)
{
  Console.WriteLine(" является квадратом.");
}
else
{
    Console.WriteLine($"не является квадратом .");
}
    