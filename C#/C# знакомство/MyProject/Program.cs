using System;

public class Program
{
    static void CheckDivisibility(int firstNumber, int secondNumber)
    {
        if (secondNumber == 0)
        {
            Console.WriteLine("На ноль делить нельзя");
        }
        else if (firstNumber % secondNumber == 0)
        {
            Console.WriteLine("делится");
        }
        else
        {
            Console.WriteLine("не делится");
        }
    }

    static void Main(string[] args)
    {
        int firstNumber = 10;
        int secondNumber = 2;

        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }

        CheckDivisibility(firstNumber, secondNumber);
    }
}
