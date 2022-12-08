// у каждого куста есть ровно два соседних Кусты посажены по кругу!.
// Всего на грядке растет N кустов.
// Эти кусты обладают разной урожайностью, 
// Собирающий модуль за один заход, собирает ягоды с этого куста и с двух соседних с ним.
// Напишите программу для нахождения максимального числа ягод,
// которое может собрать за один заход собирающий модуль,
// находясь перед некоторым кустом заданной во входном файле грядки. 
// Кустов может быть от (3 до 1000)
// Ягод на кусте не более 1000




void FillArray(int[] name)
{
    int length = name.Length;
    int index = 0;
    while (index < length)
    {
        name[index] = new Random().Next(0, 1000);
        // Console.WriteLine(name[index]);
        index++;
    }
}

Console.Clear();
int N = new Random().Next(3, 1001);               //"Генерируем кол кустов"
int[] bush = new int[N];
Console.WriteLine("Количество кустов на ферме: " + N);
FillArray(bush);

int temp = 0;
int max = 0;
int index = 0;
while (index < N)
{
    if (temp <= max && index <= N - 3)
    {
        temp = bush[index] + bush[index + 1] + bush[index + 2];
        // Console.WriteLine("1 temp " + temp);
        index++;
    }
    else if (temp <= max && index == N - 2)
    {
        temp = bush[N - 2] + bush[N - 1] + bush[0];
        // Console.WriteLine("2 temp " + temp);
        index++;
    }
    else if (temp <= max && index == N - 1)
    {
        temp = bush[N - 1] + bush[0] + bush[1];
        // Console.WriteLine("3 temp " + temp);
        index++;
    }
    else
    {
        max = temp;
        // Console.WriteLine(" max " + max);
    }
}
Console.Write("Максимальное число ягод за один заход = " + max);