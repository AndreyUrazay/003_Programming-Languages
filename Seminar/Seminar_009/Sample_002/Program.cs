﻿/*
Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

string NumbersRec(int M, int N)
{
    if (M <= N) return $"{M} " + NumbersRec(M + 1, N);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(M, N));

// version 2
// void Range(int m, int n)
// {
// if (n >= m)
// {
// Console.Write($"{m} ");
// Range(m + 1, n);
// }
// }

// Range(2, 5);