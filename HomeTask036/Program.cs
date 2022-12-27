// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();
int length = new Random().Next(25,150);             // размер массива по условиям не известен, сделал рандом в пределах
int[] array = new int[length];
int index = 0;
while (index < length)
{
    array[index] = new Random().Next(-100,100);     // Рандомное заполнение массива в пределах от -100 до 100 
    index++;                                        // ( условиях пределы не заданы )
}

int sumNumers = 0;
int j = 0;

while (j < length)
{
    if ((array[j] % 2) != 0)
        sumNumers = sumNumers + array[j];
    j++;
}
Console.Write($"Массив из {length} чисел, ");
Console.Write($"Сумма всех не четный чисел в массиве = {sumNumers}");