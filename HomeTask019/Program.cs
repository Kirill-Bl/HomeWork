// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число из 5 цифр, для проверки, является ли оно палиндромом");
Console.Write("Input N = ");
string? n = Console.ReadLine();
int size = n.Length;


while (size < 5 || size > 5)            // Проверку если будет ввод от 1 до 5 символов, вместо цифр писать не стал. Но логика понятна.
{
    Console.WriteLine();
    Console.WriteLine("Вы ввели число не из 5 цифр");
    Console.Write("Input N = ");
    n = Console.ReadLine();
    size = n.Length;
}
Console.WriteLine();
if (n[0] == n[4] && n[1] == n[3])
    Console.Write("YES");
else
    Console.Write("NO");
Console.WriteLine();