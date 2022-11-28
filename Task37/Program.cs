// Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1 : N = 5 -> 1, 2, 3, 4, 5
// M = 4 : N = 8 -> 4, 5, 6, 7, 8

Console.Write("Введите натуральное число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void NaturalNambers(int numM, int numN)
{
    if (numM == numN)
    {
        Console.Write($"{numM}");
        return;
    }
    Console.Write($"{numM} ");
    NaturalNambers(numM > numN ? numM - 1 : numM + 1, numN);
}
NaturalNambers(M, N);