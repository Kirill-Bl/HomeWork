// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int length = new Random().Next(1, 1000);    // размер массива по условиям не известен, сделал рандом
int[] array = new int[length];
int index = 0;
while (index < length)
{
    array[index] = new Random().Next(100, 999);
    index++;
}

int counter = 0;
int j = 0;

while (j < length)
{
    if ((array[j] % 2) == 0)
        counter = counter + 1;
    j++;
}
Console.Write($"Массив из {length} чисел, ");
Console.Write($"в массиве {counter} четных чисел");