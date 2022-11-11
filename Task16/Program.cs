// Напишите программу, которая принимает на вход число (N)
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.Write("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Composition(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum *= i;
    }

    return sum;
}
int composition = Composition(a);
Console.Write($"Произведение чисел от 1 до {a} = {composition}");