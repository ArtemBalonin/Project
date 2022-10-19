// Напишите программу, которая на вход принимает два числа и повторяет, 
// является ли первое число квадратом второго
// Например:
// а = 25, b = 5 -> да
// а = 2, b = 10 -> нет

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if ( num1 == num2 * num2 )
{
    Console.Write("ДА");
}
else
{
    Console.Write("НЕТ");
}
