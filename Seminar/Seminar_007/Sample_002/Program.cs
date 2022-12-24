/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

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
int[,] InitMatrix(int rows, int colums)
{
    int[,] arrMatrix = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
            arrMatrix[i, j] = i + j;
    }
    return arrMatrix;
}

void PrintInitMatrix(int[,] arrMatrix)
{
    for (int i = 0; i < arrMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < arrMatrix.GetLength(1); j++)
            Console.Write($"{arrMatrix[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
int[,] arrMatrix = InitMatrix(rows, columns);

PrintInitMatrix(arrMatrix);