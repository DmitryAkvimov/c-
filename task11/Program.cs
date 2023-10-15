/*
11. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int first = number / 100;
int last = number % 10;

System.Console.WriteLine($"{first}{last}");
