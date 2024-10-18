/*
Конечно, вот простой пример C# программы для анализа расходов. Эта программа предоставляет интерфейс для ввода расходов, категоризации и анализа.

csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> expenses = new Dictionary<string, double>();

        while (true)
        {
            Console.WriteLine("Введите расход (или 'конец' для завершения): ");
            string expenseName = Console.ReadLine();
            
            if (expenseName.ToLower() == "конец")
                break;

            Console.WriteLine("Введите сумму: ");
            double expenseAmount;
            if (double.TryParse(Console.ReadLine(), out expenseAmount))
            {
                if (expenses.ContainsKey(expenseName))
                    expenses[expenseName] += expenseAmount;
                else
                    expenses[expenseName] = expenseAmount;
            }
            else
            {
                Console.WriteLine("Неверный формат суммы. Пожалуйста, введите число.");
            }
        }

        Console.WriteLine("\nАнализ расходов:\n");

        foreach (var expense in expenses)
        {
            Console.WriteLine($"{expense.Key}: {expense.Value:C}");
        }

        double totalExpenses = expenses.Values.Sum();
        Console.WriteLine($"\nИтого расходов: {totalExpenses:C}");
    }
}


Эта программа позволяет вам вводить названия расходов и их суммы, а затем анализировать их, выводя сумму по каждой категории и общую сумму расходов.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> expenses = new Dictionary<string, double>();

        while (true)
        {
            Console.WriteLine("Введите расход (или 'конец' для завершения): ");
            string expenseName = Console.ReadLine();
            
            if (expenseName.ToLower() == "конец")
                break;

            Console.WriteLine("Введите сумму: ");
            double expenseAmount;
            if (double.TryParse(Console.ReadLine(), out expenseAmount))
            {
                if (expenses.ContainsKey(expenseName))
                    expenses[expenseName] += expenseAmount;
                else
                    expenses[expenseName] = expenseAmount;
            }
            else
            {
                Console.WriteLine("Неверный формат суммы. Пожалуйста, введите число.");
            }
        }

        Console.WriteLine("\nАнализ расходов:\n");

        foreach (var expense in expenses)
        {
            Console.WriteLine($"{expense.Key}: {expense.Value:C}");
        }

        double totalExpenses = expenses.Values.Sum();
        Console.WriteLine($"\nИтого расходов: {totalExpenses:C}");
    }
}