// Напишите программу, которая принимает  на вход координат двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// Тиарема Пифагора: A1A2 = квадратный корень(x2 - x1)**2 + (y2 - y1)**2
// C помощью функции Math.Sqrt извлекаем корень из числа
// С помощью функции Math.Round(переменная, число, т.е сколько знаков после запятой) ->
// мы округлим число
// Чтобы округлить число без автоматизма, нужно добавить 3-ий аргумент.
// MidpointRounding.ToZero
// Math - это класс, а Sqrt или Round метод 
// Пример как это работает:
// double s = 5.099965443;
// double res = Math.Round(s, 2, MidpointRounding.ToZero);
// Console.Write(res);
// Если оставить 2 переменные и убрать MidpointRoundig, то вывод будет не 5.09, а 5.1
// Тип double - это вещественное число, поэтому для получения 5.09 мы не используем int

Console.Write("Введите координату точки X1: ");
int x_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Y1: ");
int y_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки X2: ");
int x_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Y2: ");
int y_2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

double distance = Distance(x_1, x_2, y_1, y_2);
double res = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.Write(res);