// Напишите программу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти (X и Y).

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string XY (int quarters)
{
    if (quarters == 1) return "x > 0 and y > 0";
    if (quarters == 2) return "x < 0 and y > 0";
    if (quarters == 3) return "x < 0 and y < 0";
    if (quarters == 4) return "x > 0 and y < 0";
    return null;
}
string xy = XY(quarter);
Console.Write(xy == null
                 ? "Некорректный номер четверти" 
                : $"Диапозон возможных координат четверти четверти: {xy}");

// Решение с помощью оператора выбора switch-case

string Range(int quarter)
{
    switch (quarter)
    {
        case 1:
            return "x > 0 и y > 0";
        case 2:
            return "x < 0 и y > 0";
        case 3:
            return "x < 0 и y < 0";
        case 4:
            return "x > 0 и y < 0";
        default:
            return "Некорректные данные";
    }
}
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Range(quarter));