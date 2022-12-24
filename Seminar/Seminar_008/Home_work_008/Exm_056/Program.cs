/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов:");
int[,] matrix = new int[m, n];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
void FillArrayRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}

// Минимальная сумма жлементов в строке
int MinSummLine = 0;
int SummLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(matrix, i);
    if (SummLine > tempSumLine)
    {
        SummLine = tempSumLine;
        MinSummLine = i;
    }
}

Console.WriteLine($"\n{MinSummLine + 1} - строка, которая имеет наименьщую сумму элементов. Сумма элементов = {SummLine}");

int SumLineElements(int[,] matrix, int i)
{
    int SummLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        SummLine += matrix[i, j];
    }
    return SummLine;
}