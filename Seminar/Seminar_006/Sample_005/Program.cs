/*
Задача 45: Напишите программу, которая будет 
создавать копию заданного массива с помощью 
поэлементного копирования.

*/

int[] array1 = { 1, 6, 7, 10, 5 };
int[] array2 = new int[array1.Length];

for (int i = 0; i < array1.Length; i++)
    array2[i] = array1[i];
Console.WriteLine(string.Join(" ", array2));