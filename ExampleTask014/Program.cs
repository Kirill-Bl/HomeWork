// Вводим число, проверяем кратно-ли оно одновременно 7 и 23,
// Если да, выводит "кратно"
//      нет, выводит "не кратно"

Console.Clear();
Console.WriteLine("Определения одновременной кратности чисела N1 числам 7 и 23");
Console.Write("Input N1 = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
    Console.Write("Кратно");
else
    Console.Write("Не кратно");

