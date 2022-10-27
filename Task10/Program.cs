// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X и Y не равны 0 и
// выдает номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату точки X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if(xc > 0 && yc > 0) return 1;
    if(xc < 0 && yc > 0) return 2;
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти -> {quarter}"
                : "Введены некоректные координаты";
Console.Write(result);