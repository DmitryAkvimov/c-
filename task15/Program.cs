/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

while (true)
{
    Console.Write("Введите день недели : ");
    if (int.TryParse(Console.ReadLine(), out int dayNumber))
    {
        if (dayNumber >= 1 && dayNumber <= 5)
        {
            string dayName = daysOfWeek[dayNumber - 1];
            Console.WriteLine($"День недели под номером {dayNumber} - это {dayName}(Будни).");
            break; // Выход из цикла при корректном вводе
        }
        else if (dayNumber >= 6 && dayNumber <= 7)
        {
            string dayName = daysOfWeek[dayNumber - 1];
            Console.WriteLine($"День недели под номером {dayNumber} - это {dayName}(Выходной).");
            break; // Выход из цикла при корректном вводе
        }
        else
        {
            Console.WriteLine("Некорректный номер дня недели. Введите число от 1 до 7.");
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Введите число от 1 до 7.");
    }
}
       