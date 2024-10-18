using System;
public class Answer {
    static void CheckDivisibility(int firstNumber, int secondNumber) {
        if (secondNumber == 0) {
            Console.WriteLine("На ноль делить нельзя");
        } else if (firstNumber % secondNumber == 0) {
            Console.WriteLine("делится");
        } else {
            Console.WriteLine("не делится");
        }
    }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;
        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            firstNumber = 10;
            secondNumber = 2;
        }
        CheckDivisibility(firstNumber, secondNumber);
    }
}
