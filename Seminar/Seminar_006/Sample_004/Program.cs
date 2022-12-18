/*
Задача 44: Не используя рекурсию, 
выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


// int N = 20;
// int x1 = 0;
// int x2 = 1;
// int res = 0;
// string str = "0 1 ";

// for (int i = 2; i <= N; i++)
// {
// res = x2 + x1;
// x1 = x2;
// x2 = res;
// str += res.ToString() + " ";
// }

// Console.WriteLine(str);


Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int fib1 = 1;
int fib2 = 1;
int len = 0;
Console.Write($"0 {fib1} {fib2} ");
while(len < Num - 2){
int fib_sum = fib1 + fib2;
fib1 = fib2;
fib2 = fib_sum;
len++;
Console.Write($"{fib_sum} ");
}