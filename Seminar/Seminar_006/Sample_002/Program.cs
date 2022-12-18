/*
Напишите программу, которая принимает на вход три числа
 и проверяет, может ли существовать треугольник с 
 сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона 
треугольника меньше суммы двух других сторон.
*/



int GetNumber(string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}


int a = GetNumber("Введите размер 1-ой стороны треугольника:");
int b = GetNumber("Введите размер 2-ой стороны треугольника:");
int c = GetNumber("Введите размер 3-ей стороны треугольника:");

bool doCalculation(int a, int b, int c)
{
return a < b + c && b < a + c && c < a + b;
}


Console.WriteLine($"Стороны: {a}, {b}, {c}");

string ne = doCalculation(a, b, c) ? "" : " не";

Console.WriteLine($"Треугольник{ne} может существовать");