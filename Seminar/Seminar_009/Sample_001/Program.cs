﻿/*
Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в 
промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

*/


// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int num = 1;

// string NumbersRec(int num, int N)
// {
// if (num <= N) return $"{num} "+ NumbersRec(num + 1, N);
// else return String.Empty;
// }

// Console.WriteLine(NumbersRec(num, N));



Console.Write("Введите N: ");
var str = Console.ReadLine() ?? "";

int N = int.Parse(str);

string AddN(int n)
{
if (n == 1)
return n.ToString();
else
{
return AddN(n-1) + ", " + n;
}
}

Console.WriteLine(AddN(N));