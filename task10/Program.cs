/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

while (true)
{ 
Console.Write("Введите трёхзначное число: ");
        int userNumber1 = Convert.ToInt32(Console.ReadLine());
        int length = userNumber1.ToString().Length;  // Получаем количество цифр в числе
       
if (length == 3)
{
        int result = userNumber1 /10 % 10;
        System.Console.WriteLine(result);
        break;
}
else
{
    Console.WriteLine("Введено не трёхзначное число ");
}
}
