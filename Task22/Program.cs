// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишем в новом массиве.
// [1,2,3,4,5] -> 5 8 3
// [6,7,3,6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
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
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// int[] MilplicationElements(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1) size = size + 1;
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2];
//     return newArray;
// }


// int[] arr = CreateArrayRndInt(7, 1, 9);
// PrintArray(arr);
// int[] newArr = MilplicationElements(arr);
// PrintArray(newArr);


// решение с помощью цикла while
int[] CreateProdArray(int[] arr)
{
    int len = arr.Length;
    int even = len % 2;

    int[] prodArr = new int [len / 2 + even];

    int i = 0;
    while(i < len /2)
    {
        prodArr[i] = arr[i] * arr[len -1 -i];
        i++;
    }
    if(even == 1) prodArr[i] = arr[i];
    return prodArr;
}

int[] arr = CreateArrayRndInt(5, 0, 9);
Console.WriteLine(arr);
int[] prodArray = CreateProdArray(arr);
PrintArray(arr);
PrintArray(prodArray);