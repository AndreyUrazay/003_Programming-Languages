/* Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("!!!Эта программа выбирает самое большое число из 2х чисел!!!");

Console.WriteLine("Введите первое число:");
string first_number = Console.ReadLine()??"";
int number_a = Convert.ToInt32(first_number);

Console.WriteLine("Введите второе число");
string second_number = Console.ReadLine()??"";
int number_b = Convert.ToInt32(second_number);


if (number_a > number_b)
{
    Console.WriteLine($"Введеное первое число {number_a} больше второго введенного числа {number_b}");
}
else
{
    Console.WriteLine($"Введеное второе число {number_b} больше первого введенного числа {number_a}");
}