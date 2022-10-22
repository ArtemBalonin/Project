// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// Например: 456 -> 46
int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапозона 100 - 1000 = {num}");

int firstDigit = num / 100;
Console.WriteLine($"Первая цифра числа {num} = {firstDigit}");

int secondDigit = num % 10;
Console.WriteLine($"Третья цифра числа {num} = {secondDigit}");
Console.Write($"Итоговое число = {firstDigit}{secondDigit}");