/* Напишите программу, которая на входе принимает 
значение N, а на выходе показывает целые числа от -N до N
*/
Console.WriteLine("Введите число:");
string nfirst = Console.ReadLine()??"";
int n = Convert.ToInt32(nfirst);
n = Math.Abs(n);
for (int i = (-n); i <= n; i++)
{
 Console.Write(i+" ");  
}