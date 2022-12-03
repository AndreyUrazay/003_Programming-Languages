/*Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру от 1 до 7, чтобы определить является ли выбранный день недели выходным:");
string day = Console.ReadLine() ??"";

switch (day)
{
    case "1" : 
    Console.WriteLine("Нет. Понедельник - рабочий день");
    break;

    case "2" : 
    Console.WriteLine("Нет. Вторник - рабочий день");
    break;

    case "3" : 
    Console.WriteLine("Нет. Среда- рабочий день");
    break;

    case "4" : 
    Console.WriteLine("Нет. Четверг - рабочий день");
    break;

    case "5" : 
    Console.WriteLine("Нет. Пятница - рабочий день");
    break;

    case "6" : 
    Console.WriteLine("Да!!! Суббота - выходной день");
    break;

    case "7" : 
    Console.WriteLine("Да!!! Воскресенье - выходной день");
    break;

    default:
    Console.WriteLine ("Не выдумывай, у нас всего 7 дней в неделе.");
    break;
}   
