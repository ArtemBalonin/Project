﻿// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывает последнюю цифру этого числа.
// Пример
// 456 -> 6

Console.WriteLine("Введите 3-ех значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 10);
