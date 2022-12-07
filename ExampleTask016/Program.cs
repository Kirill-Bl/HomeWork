// Вводим два числа, проверяем являются ли одно число квадратом другого.
// Если да, выводит "Да"
//      нет, выводит "Нет"

Console.Clear();
Console.WriteLine("Является ли одно число квадратом другого:");
Console.Write("Input N1 = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N2 = ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 * n1 == n2 || n2 * n2 == n1)
    Console.Write("Да");
else
    Console.Write("Нет");
