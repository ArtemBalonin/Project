// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// Например: 456 -> 46
// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из диапозона 100 - 1000 = {num}");

// int firstDigit = num / 100;
// Console.WriteLine($"Первая цифра числа {num} = {firstDigit}");

// int secondDigit = num % 10;
// Console.WriteLine($"Третья цифра числа {num} = {secondDigit}");
// Console.Write($"Итоговое число = {firstDigit}{secondDigit}");


// Решение задачи с помощью создания функции.
int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапозона 100 - 1000 = {num}");

int FirstSecondNumber(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return firstDigit * 10 + secondDigit;
}
Console.Write($"Итоговое число = {FirstSecondNumber(num)}");