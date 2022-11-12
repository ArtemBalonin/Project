// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]
// Найдите сумму отрицательных и положительных элементов массива.
// [-3,9,-8,1,0,-7,2,-1,8,-3,-1,6] cумма положительных чисел равна 29
// сумма отрицательных чисел равна -20

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumpositive = 0;
    int sumnegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumpositive += array[i];
        else sumnegative += array[i];
    }
    // int [] result = {sumpositive, sumnegative};
    // return result;
    return new int[]{sumpositive, sumnegative};
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
// [0] - Сумма положительных элементов, [1] - Сумма отрицательных элементов
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");