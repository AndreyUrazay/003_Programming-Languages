/* Напишите программу, которая 
выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/



Console.WriteLine("Введи число: ");
long number = Convert.ToInt64(Console.ReadLine());
string index = Convert.ToString(number);
if (index.Length > 2)
    {
  Console.WriteLine($"Третья цифра: {index[2]}");
    }
    else 
    {
    Console.WriteLine("Третьей цифры нет. Ввели цифру меньше 100.");
    }



