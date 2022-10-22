// Напишите программу, которая принимет на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// Пример: 
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

// Первый вариант решения

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2 || num1 == num2 / num1)
// {
//     Console.Write("да");
// }
// else
// {
//     Console.Write("нет");
// }

// Второй вариант решения с помощью функции.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// string YesNo(int number1, int number2)
// {
//     return number1 == number2 * number2 || number1 == number2 / number1 ? "да" : "нет";
// }
// Console.Write(YesNo(number1, number2));

// Третий вариант решения с помощью bool.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Square(int number1, int number2)
{
    return number1 == number2 * number2 || number1 == number2 / number1;
}

bool square = Square(number1, number2);
Console.Write(square? "да" : "нет");