// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.WriteLine("Для отражения таблицы кубов чисел ряда от 1 до N");    // Что-то в процессе забыл что берем только ряд натуральных чисел.
Console.Write("Input N = ");                                      // Сделал с возможностью исчисления куба и для ряда от -N до -1.  
int n = Convert.ToInt32(Console.ReadLine());


while (n < 1)
{
    Console.WriteLine();
    Console.WriteLine("Вы ввели число меньше 1");
    Console.Write("Input N = ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

double temp = 1;
double Pow = 0;

while (temp < n + 1)
{
    Pow = Math.Pow(temp, 3);
    Console.Write($"{Pow} ");
    temp++;
}

Console.WriteLine();