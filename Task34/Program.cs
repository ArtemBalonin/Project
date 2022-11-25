// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.WriteLine($"{matrix[i, j],5} |");
        }
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k++] = matrix[i, j];
        }
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

void Dictionary(int[] array)
{
    int num = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else
        {
            Console.WriteLine($"Число {num} встречается {count} раз");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {num} встречается {count} раз");
}

Console.Write("Введите колличество строк массива: m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: n= ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, -10, 10);
PrintMatrix(matrix);

Console.WriteLine();

int[] arr = MatrixToArray(matrix);
PrintArray(arr);

Console.WriteLine();

Array.Sort(arr);
PrintArray(arr);

Console.WriteLine();

Dictionary(arr);