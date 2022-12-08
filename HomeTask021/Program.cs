// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Для расчета расстояния между точками A и B - введите координаты точек (x,y,z)");

Console.WriteLine();

Console.WriteLine("Введите координаты точки A (x,y,z)");
Console.Write("Input Xa = ");
double Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Ya = ");
double Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Za = ");
double Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите координаты точки B (x,y,z)");
Console.Write("Input Xb = ");
double Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Yb = ");
double Yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Zb = ");
double Zb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();                                            // Проверку на ввод числа, а не символа не стал делать (но можно своять)

double result = Math.Sqrt(Math.Pow(Xa - Xb, 2) + Math.Pow(Ya - Yb, 2) + Math.Pow(Za - Zb, 2));
Console.WriteLine("Расстояния между точками A и B = "+Math.Round(result, 2));
