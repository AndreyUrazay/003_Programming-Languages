/*Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число для проверки его четности");
string number = Console.ReadLine()??"";
int  first_number= Convert.ToInt32(number);

if (first_number % 2 == 0)
{
Console.WriteLine($"Число {first_number} является четным");
}   else 
    {
    Console.WriteLine($"Число {first_number} является нечетным");
    }