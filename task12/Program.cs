/*
12. Напишите программу, которая будет принимать
на вход два числа и выводить, является ли второе
число кратным первому. Если число 2 не кратно числу
1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = numberA % numberB;
if (numberA % numberB == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"Некратно, остаток: {numberC}");
}