/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие 
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] Invert(int[] array)  // конкретные значения массива Int[] arr = new {1,24,5,6};
{
for (int i = 0; i < array.Length; i++)
{
array[i] = array[i] * (-1); // можно записывать так array[i] *= (-1)
}
return array;
}

int[] RandomIntegers(int min, int max, int size = 10)
{
int[] array = new int[size];
Random r = new Random();
for (int i = 0; i < size; i++)
{
array[i] = r.Next(min, max + 1);
}
return array;
}

int[] numbers = RandomIntegers(min: -10, max: 10, size: 5); // если size не указывать будет считать 10 элементов как указано выше
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(string.Join(" ", Invert(numbers)));