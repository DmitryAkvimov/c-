using System;
class Answer {
    static void CheckNumber(int number) {
        if (number > 0) {
            Console.WriteLine("положительное");
        } else if (number < 0) {
            Console.WriteLine("отрицательное");
        } else {
            Console.WriteLine("ноль");
        }
    }

    static public void Main(string[] args) {
        int number;
        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 7;
        }
        CheckNumber(number);
    }
}
