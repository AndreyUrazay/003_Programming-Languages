/* 
ВИД 1. 
Не принимают никаких аргументов и ничего не возвращают
*/
void Method1() // идентификатор метода Method1
{
Console.WriteLine("Автор ....");
}
Method1 ();


/*
ВИД 2. 
Могут принимать аргументы, но ничего не возвращают.
*/
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;  // инкримент увеличение на 1,   деккримент - уменьшение на 1
    }
}
//Method21(msg: "Текст", count: 4);
Method21(count:4, msg: "новый текст");


/* 
ВИД 3. 
Не принимают агрументы, но могут что-то возвращать.
*/

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

/*
ВИД 4.
Принимают аргументы и возвращают.
*/


string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;

    }
    return result;
}

string res = Method4(10, " qwerty ");
Console.WriteLine(res);