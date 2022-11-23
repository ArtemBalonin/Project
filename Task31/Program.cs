// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// с индексами (0, 0), (1, 1) и т д


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 3}");
            else Console.WriteLine($"{matrix[i, j], 3}");
        }   
    }
    Console.WriteLine("");
}

int[,] arr2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(arr2D);

int FindSumDiagonal(int[,] matrix)
{
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1) ; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int result = FindSumDiagonal(arr2D);
Console.WriteLine($"Сумма элементов, стоящих на главной диагонали = {result}");