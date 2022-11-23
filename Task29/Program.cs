// Задайте двумерный массив размера m*n,
// каждый элемент в массиве наъодится по формуле:
// Amn = m + n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0  1  2  3
// 1  2  3  4
// 2  3  4  5


int[,] CreateMatrixSumIndex(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = i + j; 
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 5}");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите колличество строк массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixSumIndex(m, n);
PrintMatrix(matrix);