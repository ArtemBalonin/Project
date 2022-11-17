// Напишите программу, которая принимает на вход 3 числа и проверет,
// может ли существовать треугольник с сторонами такой длины.
//  Теорема о не равенстве треугольника: Каждая сторона треугольника
// меньше суммы двух других сторон.

bool IsTriangle(int side1, int side2, int side3)
{
    return side1 < side2 + side3 & side2 < side1 + side2 & side3 < side1 + side2; 
}

Console.WriteLine("Введите сторону А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону В: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону С: ");
int c = Convert.ToInt32(Console.ReadLine());

bool isTriangle = IsTriangle(a, b, c);
Console.Write(isTriangle ? "Треугольник существует" : "Треугольник не существует");