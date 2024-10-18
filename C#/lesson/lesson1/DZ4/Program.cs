using System;
public class Answer {
    static void PrintOddNumbers(int number) {
        for (int i = 1; i <= number; i += 2) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static public void Main(string[] args) {
        int number;
        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 5;
        }
        PrintOddNumbers(number);
    }
}
