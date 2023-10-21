/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/
Console.WriteLine("Введите координаты точки. X: ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки. Y: ");
int userY = Convert.ToInt32(Console.ReadLine());

if (userX > 0 && userY > 0)
{
    System.Console.WriteLine("Первая четверть");
}
if (userX < 0 && userY > 0)
{
    System.Console.WriteLine("Вторая четверть");
}
if (userX < 0 && userY < 0)
{
    System.Console.WriteLine("Третья четверть");
}
if (userX > 0 && userY < 0)
{
    System.Console.WriteLine("Четвертая четверть");
}
if (userX == 0 || userY == 0)
{
    System.Console.WriteLine("Точка находится на оси координат");
}