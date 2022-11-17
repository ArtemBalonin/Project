// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// // 1 решение через int.

// int DecToBin(int number)
// {
//     int binNumber = 0;
//     int d10 = 1;
//     while (number > 0)
//     {
//         binNumber = binNumber + number % 2 * d10;
//         number /= 2;
//         d10 *= 10;
//     }
//     return binNumber;
// }

// int decToBin = DecToBin(num);
// Console.WriteLine($"Число {num} в двоичной системе = {decToBin}");

// 2 решение с помощью string.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string ConverterDigit(int num)
{
    string res = "";
    while (num > 0)
    {
        res = $"{(num % 2)}{res}";
        num /= 2;
    }
    return res;
}

string converterDigit = ConverterDigit(num);
Console.WriteLine($"Число {num} в двоичной системе = {converterDigit}");