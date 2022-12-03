/* Напишите программу, которая принимает 3х значное число 
и на выходе показывает последнее цифру этого числа
456 - 6
782 - 2
918 -8
*/

Console.WriteLine ("Введите 3х значное число:");
string nstring = Console.ReadLine()??"";
int n = Convert.ToInt32(nstring);
if ((n>=100) && (n<=999))
    Console.WriteLine(n % 10);
else
    Console.WriteLine("Неверно введено число");
