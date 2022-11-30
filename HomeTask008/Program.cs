// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Для отражения всех чётных чисел от 1 до N");
Console.WriteLine("N - натуральное число");
Console.Write("Input N = ");
int n =  Convert.ToInt32(Console.ReadLine());   

while (n <= 0)
{    
    Console.WriteLine("Вы  ввели не натуральное число от 1 до N");
    Console.Write("Input N = ");
    n = Convert.ToInt32(Console.ReadLine());   
}
if (n % 2 == 0)
    Console.WriteLine("Ряд чётный чисел:");
else if (n <= 1)
        Console.WriteLine("Чётных чисел нет.");
else
        Console.WriteLine("Ряд чётный чисел:");

for (int a =2; a < n+1; a = a+2)
    Console.Write($"{a} ");

