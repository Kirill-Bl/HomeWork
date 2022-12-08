// Вводим два числа, проверяем кратно-ли первое число второму,
// Если да, выводит "кратно"
//      нет, выводит остаток от деления

Console.Clear();
Console.WriteLine("Определения кратности чисела N1 числу N2");
Console.Write("Input N1 = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N2 = ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 % n2 == 0)
    Console.Write("Кратно");
else
    Console.Write($"Не кратно, остаток {n1 % n2}");

