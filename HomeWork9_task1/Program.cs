/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/

//получить числа с консоли
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число меньше либо равно 1");
        }
    }

    return result;
}

//вывод чісел от n до 1
string GetValues(int n)
{
    if (n == 1) return "1";
    
    return n.ToString() + " " + GetValues(n-1); 
}

int n = GetNumber("Введите число больше 1");

GetValues(n);
Console.WriteLine(GetValues(n));