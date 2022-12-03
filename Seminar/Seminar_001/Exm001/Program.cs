/* 
Напишите программу, которая на входе принимает число и выдает его квадрат (число умноженное на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine() ??"";
int number = Convert.ToInt32(numberStr);// -2147483647 to 2147483647  32bit
// long q -9223372036854775807 to 9223372036854775807   64bit

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");