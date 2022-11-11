// Напишите программу, которая выводит массив из 8 элементов, 
// заполняя нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length -1 ) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] array = new int [8];
FillArray(array);
PrintArray(array);