// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6,7,19,345,3] -> нет
// 3; массив [6,7,19,345,3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool FindNumberArray(int[] array) // мы можем добавить аргумент int number, тогда метод будет принимать заданное число.
{
    Console.Write("Введите число: "); // Если добавить аргумент, то можно удалить строки с просьбой о введение числа.
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number) return true;
    }
    return false;
}

int[] arr = CreateArrayRndInt(10, -5, 10);
PrintArray(arr);
bool result = FindNumberArray(arr);

Console.WriteLine(result? "Да": "Нет");