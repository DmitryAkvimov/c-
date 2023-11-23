/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
using System;

class AckermannProgram
{
    void Run()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        if (m >= 0 && n >= 0)
        {
            int result = CalculateAckermann(m, n);
            Console.WriteLine($"A({m}, {n}) = {result}");
        }
        else
        {
            Console.WriteLine("m и n должны быть неотрицательными числами.");
        }
    }

    int CalculateAckermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return CalculateAckermann(m - 1, 1);
        }
        else
        {
            return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
        }
    }

    static void Main()
    {
        AckermannProgram program = new AckermannProgram();
        program.Run();
    }
}

