// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапозона 10 -99 -> {num}");

// int firstDigit = num / 10; // 78 /10 = 7
// int secondDigit = num % 10; // 78 % 10 = 8

// 1 способ
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {num} = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {num} = {secondDigit}");

// 2 способо Тернарный оператор
// int result = firstDigit > secondDigit ? firstDigit : secondDigit; //--> тернарный оператор.
// Если firstDigit больше secondDigit (тогда ?) в переменную result мы записываем значение firstDigit,
// (иначе :) мы запишем значение secondDigit
// Console.WriteLine($"Наибольшая цифра числа {num} = {result}");  

// 3 способ
// Используем встроенный метод Math.Max

// int max = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {num} = {max}");

// Реализовываем данную задачу с помощью функции

int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 /10 = 7
    int secondDigit = num % 10; // 78 % 10 = 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");