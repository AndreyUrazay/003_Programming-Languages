/* 
Напишите программу, которая на входе принимает число и выдает его квадрат (число умноженное на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        else
            Console.WriteLine ("Ввели не число");
    }
    return result;
}

int number = GetNumber("Введите число:");

int result = number * number;

Console.WriteLine("Квадрат числа {number} = {result}");
Console.WriteLine($"Квадрат числа {number} = {result}");
