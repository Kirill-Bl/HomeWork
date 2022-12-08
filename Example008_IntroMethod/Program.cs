int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.WriteLine("Отражение наибольшего числа из девяти введенных чисел");
Console.WriteLine("Введите числа");
Console.Write("Input 1  ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2  ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3  ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 4  ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 5  ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 6  ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 7  ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 8  ");
int b3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 9  ");
int c3 = Convert.ToInt32(Console.ReadLine());

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine("Наибольшее число из девяти введенных чисел");
Console.WriteLine(max);