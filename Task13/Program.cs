// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до (N)
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

void Table(int n)
{
    if (n > 0)
    {
        int index = 1;
        while (index <=n)
        {
            Console.WriteLine($"{index,4}    {Math.Pow(index, 2)}");
            index++;
        }
    }
    else Console.WriteLine("Некорректное число");
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);