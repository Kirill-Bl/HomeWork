// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.WriteLine("Для отражения таблицы кубов чисел ряда N");    // Что-то в процессе забыл что берем только ряд натуральных чисел.
Console.Write("Input N = ");                                      // Сделал с возможностью исчисления куба и для ряда от -N до -1.  
double n = Convert.ToDouble(Console.ReadLine());


while (n == 0)
{
    Console.WriteLine();
    Console.WriteLine("Вы  ввели 0");
    Console.Write("Input N = ");
    n = Convert.ToDouble(Console.ReadLine());
}


Console.WriteLine();


int N = Math.Abs(Convert.ToInt32(n));
double[] arrayA = new double[N];


void FillArray(double[] name)
{
    int length = name.Length;
    if (n < 0)
    {
        double a = n;
        int index = 0;
        while (index < length)
        {
            name[index] = a;
            a = a + 1;
            index++;
        }
    }
    else if (n > 0)
    {
        double a = 1;
        int index = 0;
        while (index < length)
        {
            name[index] = a;
            a = a + 1;
            index++;
        }
    }
}
FillArray(arrayA);


int ind = 0;
double a3 = 0;
double A3 = 0;

while (ind < Math.Abs(n))
{
    A3 = arrayA[ind];
    a3 = Math.Pow(A3, 3);
    Console.Write($"{a3} ");
    ind++;
}
Console.WriteLine();