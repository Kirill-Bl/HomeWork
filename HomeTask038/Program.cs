// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int length = new Random().Next(25, 100);             // размер массива по условиям не известен, сделал рандом в пределах
int[] array = new int[length];
int index = 0;
while (index < length)
{
    array[index] = new Random().Next(1, 100);     // Рандомное заполнение массива в пределах от 1 до 100 
    index++;                                     // ( условиях пределы не заданы )
}

int max = 0;
int min = array[0];
int i = 0;

// array[1]=1000;                                   // Проверка
// array[23]=1;

while (i < length)
{
    if (array[i] > max)
        max = array[i];
    if (array[i] <= min)
        min = array[i];
    i++;
}
Console.Write($"Массив из {length} чисел, ");
Console.Write($"Разница максимального и минимального числа в массиве = {(max - min)}");