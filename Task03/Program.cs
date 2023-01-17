﻿/*
Напишите программу, которая 
1. на вход принимает одно число (N),
2. на выходе показывает все целые числа в промежутке от -N до N.

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int count = -number;

    while (count <= number)
        {
        Console.Write($"{count} ");
        count++; //count = count + 1
        }
}
else
{
    Console.WriteLine("Введите натуральное число!");
}
