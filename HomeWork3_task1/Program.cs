/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число");
string x1 = Console.ReadLine();
char[] arr = x1.ToCharArray();
Array.Reverse(arr);
string x2 = new String(arr);
 
if (x1 == x2) Console.WriteLine("Палиндром");
 else Console.WriteLine("Не палиндром");

