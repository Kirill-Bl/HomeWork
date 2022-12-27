// Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы.
// После записи элементов в массив, необходимо его вывести на экран.
// 8
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.Clear();
Console.Write("Введите количество элиментов массива ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int i = 0;
while (i < N)
{
    Console.Write($"Введите {(i + 1)} число массива ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.Write("[");
int j = 0;
while (j < (N-1))
{
    Console.Write($"{array[j]}, ");
    j++;
}
Console.Write($"{array[(N-1)]}]");
