string[] InputArr(char x = ' ')
{

    Console.Write($"Для выполнения алгоритма введите символы через пробел {x}: ");
    string symbol = Console.ReadLine()?? " ";
    return symbol.Split(x);
}


string[] SelectItem(string[] arr, int selectLength = 3)
{
    int count = 0;

    foreach (string item in arr)
    {
        if (item.Length <= selectLength)
        {
            count++;
        } 
    }
    string[] result = new string[count];

    if (count == 0) return result;
    else
    {
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= selectLength) 
            {
                result[index] = arr[i];
                index++;
            }
        }
        return result;
    }
}
