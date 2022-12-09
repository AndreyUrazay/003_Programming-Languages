/*
Напишите цикл, который принимает на вход
 два числа (A и B) и возводит
 число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        System.Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            System.Console.WriteLine("Некорректный ввод. Введите число");
        }
    }
    return result;
}


int number_a = GetNumber("Введите число, которое возведем в степень:");
int number_b = GetNumber("Введите число степени:");


// Console.WriteLine("Введите число, которое возведем в степень:");
// int number_a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число степени:");
// int number_b = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow((number_a),number_b);

Console.WriteLine($"{result} является результатом возведения числа {number_a} в степень {number_b}");


