// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли первое число кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// Пример: 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if ( firstDigit % secondDigit == 0) Console.Write("Кратно");
else
{
    int num = firstDigit % secondDigit;
    Console.Write($"не кратно, остаток {num}");
}