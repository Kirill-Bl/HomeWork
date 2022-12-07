﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число, программа отобразит третью цифру");
Console.Write("Input N = ");
int n = Convert.ToInt32(Console.ReadLine());         //  вопрос максимально вводимого числа, есть ограничение размера "тип C#"
if (n < 100)
    Console.WriteLine("третьей цифры нет");
else
{
    while (n > 1000)
    {
        n = n / 10;
    }
    n = n % 10;
    Console.WriteLine("третья цифра " + n);
}
