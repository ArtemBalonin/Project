// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    if(number == 0) return 0;
    return number%10 + SumNumbers(number / 10);

}

int sum = SumNumbers(num);
Console.Write(sum);