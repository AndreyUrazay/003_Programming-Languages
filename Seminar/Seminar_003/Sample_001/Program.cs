/* Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

        2   |
            |   1
----------------------->
            |
    3       |   4

*/

/*
1. reference types (ссылочные типы) - class, char, arrays, list (Хранятся в управляемой куче памяти)
2. value types (значимые типы) - int, long, double, datetime, struct, enum, decinal (Хранятся на стеке/оперативной памяти)
*/


int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result !=0) // TryParse безопасное преобразование из string в int
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число");
        }
    }
    return result;
}

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    return 1;
    if (x<0 && y>0)
    return 2;
    if (x<0 && y<0)
    return 3;

    return 4;    
}

int x = GetNumber("Введите координату х=");
int y = GetNumber("Введите координату y=");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в {quarter} четверти");
