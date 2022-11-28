// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А = 3; В = 5; -> 243(3 в пятой степени)

int Degree(int number1, int number2)
{
    if (number2 == 0) return 1;
    return number1 * Degree(number1, number2 - 1);
}

Console.Write("Введите натуральное число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число В: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b >= 0)
{
    int degree = Degree(a, b);
    Console.Write(degree);
}
else Console.Write("Введите натуральную степень числа ");