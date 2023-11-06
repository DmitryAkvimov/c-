/*
Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

using System;

double[] GetIntersectionPoint()
{
     double[] coefficients = new double[4];

    Console.WriteLine("Введите значение b1: ");
    coefficients[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение k1: ");
    coefficients[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b2: ");
    coefficients[2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение k2: ");
    coefficients[3] = Convert.ToDouble(Console.ReadLine());

    double k1 = coefficients[1];
    double b1 = coefficients[0];
    double k2 = coefficients[3];
    double b2 = coefficients[2];

    // Решение системы уравнений для нахождения точки пересечения
    double x_intersection = (b2 - b1) / (k1 - k2);
    double y_intersection = k1 * x_intersection + b1;

    return new double[] { x_intersection, y_intersection };
}

    
    double[] intersectionPoint = GetIntersectionPoint();
    Console.WriteLine("Точка пересечения двух прямых:");
    Console.WriteLine($"x = {intersectionPoint[0]:N1}");
    Console.WriteLine($"y = {intersectionPoint[1]:N1}");
    
