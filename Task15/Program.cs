// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3
// 56 -> 2
// 1234567 -> 7

// Решение с помощью цикла For

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int NumberDigits(int num)
// {
//     int digits = 0;
//     for (int i = 0; i < num | i > num;)
//     {
//         num /= 10;
//         digits += 1;
//     }
//     return digits;
// }
// if (a != 0)
// {
//     int num = NumberDigits(a);
//     Console.Write($"Колличество цифр в числе {a} = {num}");
// }
// else Console.Write($"В введеном числе {a}, всего 1 цифра");

// Решение с помощью цикла Wille

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int CountDigits(int num)
{
    int count = 0;
    while (num != 0)
    {
        count ++;
        num /= 10;
    }
    return count == 0 ? 1 : count;
}

int countDigits = CountDigits(a);
Console.WriteLine($"Колличество цифр в числе {a} = {countDigits}");