﻿// Показать числа Фибоначчи меньше заданного числа N.
int[]fibonacci = new int [1000];
fibonacci[0]=1;
fibonacci[1]=1;
int n = int.Parse(Console.ReadLine()??"0");
Console.Write($"{fibonacci[0]}{fibonacci[1]}");
int index = 1;
while(fibonacci[index]<n)
{
    index++;
    fibonacci[index]=fibonacci[index-1]+fibonacci[index-2];
    if (fibonacci[index]<n)
    Console.Write($"{fibonacci[index]}");
}
