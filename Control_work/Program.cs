string[] InputArr(char x = ' ')
{

    Console.Write($"Для выполнения алгоритма введите символы через пробел {x}: ");
    string symbol = Console.ReadLine()?? " ";
    return symbol.Split(x);
}


