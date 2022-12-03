/*
Задача №1. Напишите программу, 
которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/


Console.WriteLine("Введите 1-е число:");
string inputA = Console.ReadLine() ??"";
int numberA = Convert.ToInt32(inputA);

Console.WriteLine("Введите 2-е число:");
string inputB = Console.ReadLine() ??"";
int numberB = Convert.ToInt32(inputB);

if  (((numberB) * (numberB)) == numberA)
{
    Console.WriteLine($"1-е число {numberA} является квадратом 2-го числа {numberB}");
} else 
{
    Console.WriteLine($"1-е число {numberA} не является квадратом 2-го числа {numberB}");
}


