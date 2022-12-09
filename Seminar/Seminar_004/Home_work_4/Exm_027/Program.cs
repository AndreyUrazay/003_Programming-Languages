/* Напишите программу, которая 
принимает на вход число и выдаёт 
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


int SumNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        System.Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            System.Console.WriteLine("Некорректный ввод. Введите число");
        }
    }
    return result;
}

int number = SumNumber("Введите число для подсчета суммы чисел данного числа: ");


int sumNumber = 0;

while (number > 0)
{
int numb = number % 10;
number = number / 10;
sumNumber = sumNumber + numb;
}

Console.WriteLine($"Сумма цифр в числе = {sumNumber}");


