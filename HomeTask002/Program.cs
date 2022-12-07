// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Input a = ");
int a =  Convert.ToInt32(Console.ReadLine());       // вариант 1 ввода числа

Console.Write("Input b = ");
int b = int.Parse(Console.ReadLine());              // вариант 2 ввода числа

if( a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
}