/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Random pkp = new Random();
int number = pkp.Next(100, 1000);

Console.WriteLine($"{number}");

int secondDigit = number / 10 % 10;
Console.WriteLine($"Вторая цифра числа {secondDigit}");
