/* Напишите программу, которая выводит случайное 
трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

*/

int GetRandomNumber()
{
    return new Random().Next(100, 1000); // 100....999
}

void ShowRandomNumber(int number)
{
    Console.WriteLine($"Случайное 3-х значноечисло: {number}");
    string str = number.ToString();
    Console.WriteLine($"> {str[0]}{str[2]}");
}

ShowRandomNumber(GetRandomNumber()); 

void ShowRandomNumberSecond(int number)
{
    Console.WriteLine($"Случайное 3-х значноечисло: {number}");
    int result = (((number / 100) *10)+ (number %10));
    Console.WriteLine($"> {result}");
}

ShowRandomNumberSecond(GetRandomNumber()); 