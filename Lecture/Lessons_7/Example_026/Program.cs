﻿/*
Есть 5 игроков
Нужно показать все разбиения игроков на две команды

0-игроков попадает в первую команду
1-игроков попадает во вторую команду

попробуйте адаптировать
*/

int n=1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length==word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length+1);
    }
}
FindWords("аисв", new char[3]);