/* Напишите программу, которая принимает 
на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите 3х значное число:");

string nstring = Console.ReadLine() ?? "";
int n = Convert.ToInt32(nstring);
if ((n >= 100) && (n <= 999))
{
    int result = (((n%100)-(n % 10))/10);
    Console.WriteLine(result);
}
else
    Console.WriteLine("Неверно введено число");

