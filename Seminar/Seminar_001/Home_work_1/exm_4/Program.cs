/* Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("!!!Эта программа выбирает самое большое число из 3х чисел!!!");

Console.WriteLine("Введите первое число:");
string first_number = Console.ReadLine()??"";
int number_a = Convert.ToInt32(first_number);

Console.WriteLine("Введите второе число");
string second_number = Console.ReadLine()??"";
int number_b = Convert.ToInt32(second_number);

Console.WriteLine("Введите третье число");
string third_number = Console.ReadLine()??"";
int number_c = Convert.ToInt32(third_number);

{
    if (number_a > number_b && number_a > number_c)
    {
    Console.WriteLine($"Введеное первое число {number_a} самое большое из введенных чисел {number_b} и {number_c}");
    }
        else if (number_b > number_a && number_b > number_c)
        {
        Console.WriteLine($"Введеное второе число {number_b} самое большое из введенных чисел {number_a} и {number_c}");
        }
            else if (number_c > number_a && number_c > number_b)
            {
            Console.WriteLine($"Введеное третье число {number_c} самое большое из введенных чисел {number_a} и {number_b}");
            }        
}
