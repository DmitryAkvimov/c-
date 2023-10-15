/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трёхзначное число: ");
        int userNumber1 = Convert.ToInt32(Console.ReadLine());

        int result = userNumber1 /10 % 10;

        System.Console.WriteLine(result);