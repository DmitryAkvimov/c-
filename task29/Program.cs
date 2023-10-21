/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();

void Sum()
{
    System.Console.WriteLine("Введите число: "); 
    int userNumber = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    int count = 0;

    while(userNumber > count)
    {
        sum += userNumber % 10;
        userNumber = userNumber / 10;
    }
    System.Console.WriteLine(sum);
}

Sum();