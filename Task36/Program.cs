// задайте значение N. Напишите программу, которая выдает все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNambers(int num)
{
    if(num == 0) return;
    NaturalNambers(num - 1);
    Console.Write($"{num} ");

}

NaturalNambers(number);
