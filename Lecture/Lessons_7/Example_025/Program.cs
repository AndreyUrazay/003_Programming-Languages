﻿/*
Перебор слов

В некотором машинном алфавите имеются 
четыре буквы "а","и" "с" и "в".
Покажите все слова, состоящие из Т букв,
которые можно постороить из букы этого алфавита
*/

// итеративный способ
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; i++)
                {
                    Console.WriteLine($"{n++,-5} {s[i]} {s[j]} {s[k]} {s[l]} {s[m]}");
                }
            }
        }
    }
}