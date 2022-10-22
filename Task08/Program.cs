// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Пример: 
// 14 -> нет
// 46 -> нет
// 161 -> да

// Первый вариант решения

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 7 == 0 && num % 23 == 0)
// { 
//     Console.Write("да");
// }

// else 
// {
//     Console.Write("нет");
// }

// Второй вариант решения с помощью функции.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string YesNo(int num)
{
    return num % 7 == 0 && num % 23 == 0 ? "да" : "нет";
}
Console.Write(YesNo(num));