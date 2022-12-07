﻿// Задана последовательность натуральных чисел, завершающаяся числом 0.
// Требуется определить значение второго по величине элемента в этой последовательности,
// то есть элемента, который будет наибольшим,
// если из последовательности удалить наибольший элемент.
// Входные данные
// Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. 
// Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.

Console.Clear();
Console.WriteLine("Генеруем ряд чисел");
int n = new Random().Next(0, 100);
int max1 = n;                               // Первое по величине число в ряду.
int max2 = 0;                               // Второе по величине число в ряду.
int numers = 0;                             // Переменная для определения второго по величине числа в ряду.
while (n != 0)
{
    if (n >= max1)
        max1 = n;
    else
    {
        numers = n;

        if (numers >= max2)
            max2 = numers;
    }
    n = new Random().Next(0, 100);
    Console.Write(" " + n);
}
Console.WriteLine(" END");                                          // - подтверждение что цикл закончил строить рандомный ряд на 0

// Console.WriteLine("первое по величине число в ряду " + max1);    // - для проверки
Console.WriteLine("второе по величине число в ряду " + max2);