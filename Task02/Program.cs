// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Пример:
// 3 -> среда
// 5 -> пятница

Console.Write("Введите целое число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1) Console.Write("Понедельник");
// if (num == 2) Console.Write("Вторник");
// if (num == 3) Console.Write("Среда");
// if (num == 4) Console.Write("Четверг");
// if (num == 5) Console.Write("Пятница");
// if (num == 6) Console.Write("Суббота");
// if (num == 7) Console.Write("Воскресенье");
// if (num > 7 || num < 1) Console.Write("Такого дня недели не существует");

// Оптимизируем код

if (num > 0 && num < 8)
{
    if (num == 1) Console.Write("Понедельник");
    else if (num == 2) Console.Write("Вторник");
    else if (num == 3) Console.Write("Среда");
    else if (num == 4) Console.Write("Четверг");
    else if (num == 5) Console.Write("Пятница");
    else if (num == 6) Console.Write("Суббота");
    else Console.Write("Воскресенье");
}
else Console.Write("Такого дня недели не существует");