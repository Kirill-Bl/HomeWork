// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.Write("Input A = ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input B = ");
double b = Convert.ToInt32(Console.ReadLine()); // Проверку на 0 и отрицательные и т.д. прописывать не стал
double result = a;
int i = 1;
while (i < b)
{
    result = result * a;
    i++;
}
Console.Write(result);