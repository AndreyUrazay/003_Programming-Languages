/*
 Задайте массив вещественных чисел. 
 Найдите разницу между максимальным 
 и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

//получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }

    return array;
}

//распечатать массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

int[] array = InitArray(GetNumber("Введите размер массива для генерации чисел: "));
PrintArray(array);

double min_number = Int32.MaxValue;
double max_number = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max_number)
        {
            max_number = array[i];
        }
    if (array[i] < min_number)
        {
            min_number = array[i];
        }
}

Console.WriteLine($"Всего {array.Length} чисел. Максимальное значение = {max_number}, минимальное значение = {min_number}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {(max_number) - (min_number)}");
