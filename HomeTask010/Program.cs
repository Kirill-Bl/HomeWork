// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Отобразит вторую цифру введеноготрех значного числа");
Console.Write("Input N = ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
    Console.WriteLine("Вы не ввели ТРЕХЗНАЧНОЕ число");
    Console.Write("Input N = ");
    n = Convert.ToInt32(Console.ReadLine());
}
n = n % 100;
n = (n - (n % 10)) / 10;
Console.Write(n);
