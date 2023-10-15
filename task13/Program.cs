/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine()); // Чтение ввидимого числа

int length = userNumber.ToString().Length;  // Получаем количество цифр в числе

if (length >= 3)
{
    int result = (userNumber / (int)Math.Pow(10, length - 3)) % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}