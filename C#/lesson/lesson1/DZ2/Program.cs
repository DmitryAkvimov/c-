using System;
public class Answer {
    static int FindMedian(int a, int b, int c) {
        if ((a >= b && a <= c) || (a >= c && a <= b)) {
            return a;
        } else if ((b >= a && b <= c) || (b >= c && b <= a)) {
            return b;
        } else {
            return c;
        }
    }

    static public void Main(string[] args) {
        int a, b, c;
        if (args.Length >= 3) {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        } else {
            a = 5;
            b = 3;
            c = 8;
        }
        int result = FindMedian(a, b, c);
        Console.WriteLine($"{result}");
    }
}
