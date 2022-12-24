/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

int rowsA = GetNumber("Введите количество строк для 1-ой матрицы:");
int columnsA = GetNumber("Введите количество столбцов для 1-ой матрицы:");
int[,] matrixA = new int[rowsA, columnsA];

int rowsB = GetNumber("Введите количество строк для 2-ой матрицы:");
int columnsB = GetNumber("Введите количество столбцов для 2-ой матрицы:");
int[,] matrixB = new int[rowsB, columnsB];


if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}

Console.WriteLine("1-ая матрица имеет следующий вид:");
FillArrayRandomNumbers(matrixA);
PrintArray(matrixA);

Console.WriteLine("2-ая матрица имеет следующий вид:");
FillArrayRandomNumbers(matrixB);
PrintArray(matrixB);

Console.WriteLine("Матрица произведения:");
FillArrayRandomNumbers(MultiplicationMatrix(matrixA, matrixB));
PrintArray(MultiplicationMatrix(matrixA, matrixB));

// проверка корректности ввода числа
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

// функция ввода рандомной матрицы
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
// функция отображения сгенерированной матрицы
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

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}