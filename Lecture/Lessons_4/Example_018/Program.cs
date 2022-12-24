// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1; // || - это или
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"F({i}) = {Fibonacci(i)}");
}